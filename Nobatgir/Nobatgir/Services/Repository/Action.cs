using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nobatgir.Data;
using Nobatgir.Model;

namespace Nobatgir.Services
{
    public partial class Repository
    {
        public Model.Action GetAction(int id)
        {
            return FilterExist(_myContext.Actions).FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<Model.Action> GetActions()
        {
            return FilterExist(_myContext.Actions);
        }

        public IQueryable<Model.Action> GetActiveActions()
        {
            var adminMenus = FilterActive(this.GetActions());
            return adminMenus;
        }

        public IQueryable<Model.Action> GetActions(int ActionCategoryID)
        {
            return this.GetActions().Where(x => x.ActionCategoryID == ActionCategoryID);
        }

        public IQueryable<Model.Action> GetActiveActions(int ActionCategoryID)
        {
            var Actions = FilterActive(GetActions(ActionCategoryID));
            return Actions;
        }

        public PagedResult<Model.Action> GetActions(int ActionCategoryID, int pageNumber, string searchString = "")
        {
            var q = this.GetActions(ActionCategoryID);
            return GetPagedResult(q, pageNumber, searchString);
        }

        public PagedResult<Model.Action> GetActions(int pageNumber, string searchString = "")
        {
            return GetPagedResult(this.GetActions(), pageNumber, searchString);
        }
    }
}
