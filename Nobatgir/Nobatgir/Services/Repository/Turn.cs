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
                RegDate = DateTime.Now,
                Status = TurnStatuses.Reserve
            });

            _myContext.SaveChanges();

            return t.Entity;
        }

        public Model.Turn GetTurn(Guid id)
        {
            var t = _myContext.Turns.Include(x => x.TurnDetails).FirstOrDefault(x => x.ID == id);

            return t;
        }

        public IEnumerable<Model.Turn> GetTurnsExpert(int ExpertID, DateTime dtfrom, DateTime dtto)
        {
            var t = _myContext.Turns.Where(x => x.ExpertID == ExpertID && x.TurnDate >= dtfrom && x.TurnDate <= dtto);
            return t;
        }

        public string GetTurnDetailsValue(Model.Turn turn, int expertfieldid, bool returntext)
        {
            var turndetails = turn.TurnDetails.FirstOrDefault(x => x.ExpertFieldID == expertfieldid);

            if (turndetails == null)
                return null;

            // اگر نوع کنترل کمبو باشد باید متن آن استخراج شود و برگردد
            if (turndetails.ExpertField.FieldType == FieldTypes.ComboBox)
            {
                var r = turndetails.ExpertField.SourceType.SourceValues.FirstOrDefault(x => x.ID.ToString() == turndetails.Value)?.Title;

                return r;
            }

            return turndetails.Value;
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
    }
}
