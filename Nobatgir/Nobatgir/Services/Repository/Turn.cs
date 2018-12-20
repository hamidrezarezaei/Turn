using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nobatgir.Data;
using Nobatgir.Model;
using Nobatgir.ViewModel;

namespace Nobatgir.Services
{
    public partial class Repository
    {
        public Model.Turn AddTurn(DateTime turndate, string time)
        {
            var t = _myContext.Turns.Add(new Model.Turn
            {
                ExpertID = this.ExpertID,
                TurnDate = new DateTime(turndate.Year, turndate.Month, turndate.Day),
                Time = time,
                Status = TurnStatuses.Reserve,
                RegDate = DateTime.Now,
                ExpireTime = DateTime.Now.AddMinutes(2)
            });

            _myContext.SaveChanges();

            return t.Entity;
        }

        /// <summary>
        /// آیا برای این زمان نوبتی گرفته شده یا نه
        /// </summary>
        /// <param name="time"></param>
        /// <param name="turndate"></param>
        /// <returns></returns>
        public Turn CheckTurnConflict(string time, DateTime turndate)
        {
            // اگر شخص دیگری برای این زمان رزرو گرفته یا کامل شده
            var f = _myContext.Turns.Where(x => x.Time == time
                                              && x.TurnDate == turndate
                                              && (x.Status == TurnStatuses.Completed
                                                  || (x.Status == TurnStatuses.Reserve) && x.ExpireTime.CompareTo(DateTime.Now) > 0)).ToList();

            if (f.Count > 1)
                throw new Exception("نوبت اشتباه شده ثبت شده.");

            return f.Count == 1 ? f[0] : null;
        }

        public Turn GetTurn(Guid id)
        {
            var t = _myContext.Turns.Include(x => x.TurnDetails).FirstOrDefault(x => x.ID == id);

            return t;
        }

        public void CancelTurn(Guid id)
        {
            var t = GetTurn(id);

            t.Status = TurnStatuses.Canceled;

            _myContext.SaveChanges();
        }

        public void CompleteTurn(Guid id)
        {
            var t = GetTurn(id);

            t.TrackingCode = t.TurnDetails.First().ID;

            t.Status = TurnStatuses.Completed;

            _myContext.SaveChanges();
        }

        public IEnumerable<Turn> GetTurnsExpert(int expertID, DateTime dtfrom, DateTime dtto)
        {
            var t = _myContext.Turns.Where(x => x.ExpertID == expertID && x.TurnDate >= dtfrom && x.TurnDate <= dtto);
            return t;
        }

        public string GetTurnDetailsTitle(Model.Turn turn, int expertfieldid, bool returntext)
        {
            var turndetails = turn.TurnDetails.FirstOrDefault(x => x.ExpertFieldID == expertfieldid);

            if (turndetails == null)
                return null;

            // اگر نوع کنترل کمبو باشد باید متن آن استخراج شود و برگردد
            if (turndetails.ExpertField.FieldType == FieldTypes.ComboBox && returntext)
            {
                var r = turndetails.ExpertField.SourceType.SourceValues.FirstOrDefault(x => x.ID.ToString() == turndetails.Value)?.Title;

                return r;
            }

            return turndetails.Value;
        }

        public int DeleteTurnDetails(Guid turnid)
        {
            var t = _myContext.TurnDetails.Where(x => x.TurnID == turnid);

            _myContext.TurnDetails.RemoveRange(t);
    
            return _myContext.SaveChanges();
        }

        public int AddTurnDetails(Guid turnid, List<ExpertFieldsViewModel> fields)
        {
            foreach (var item in fields)
            {
                if (item.FieldType == FieldTypes.HTML)
                    continue;

                _myContext.TurnDetails.Add(new TurnDetails
                {
                    TurnID = turnid,
                    ExpertFieldID = item.ID,
                    Value = item.Value
                });
            }

            return _myContext.SaveChanges();
        }

        public IEnumerable<TurnDetails> GetTurnDetails(Guid turnid)
        {
            return _myContext.TurnDetails.Include(x => x.ExpertField).Where(X => X.TurnID == turnid);
        }

        public string GetTurnDetailsValue(Guid turnid, string fieldname)
        {
            var td = _myContext.TurnDetails.Include(x => x.ExpertField).FirstOrDefault(X => X.TurnID == turnid && X.ExpertField.Name.ToLower() == fieldname.ToLower());

            if (td == null)
                return null;

            // اگر فهرست است باید مقدار را از مقادیر پیدا شود
            if (td.ExpertField.FieldType == FieldTypes.ComboBox)
                return _myContext.SourceValues.FirstOrDefault(x => x.ID.ToString() == td.Value)?.Value;

            return td.Value;
        }
    }
}
