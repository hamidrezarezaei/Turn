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
                TurnDate = turndate,
                Time = time,
                RegDate = DateTime.Now,
                Status = TurnStatuses.Reserve
            });

            _myContext.SaveChanges();

            return t.Entity;
        }

        public Model.Turn GetTurn(Guid id)
        {
            var t = _myContext.Turns.FirstOrDefault(x => x.ID == id);

            return t;
        }
    }
}
