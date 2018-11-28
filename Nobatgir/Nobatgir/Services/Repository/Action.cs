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
        public Model.Act GetAction(int id)
        {
            return FilterExist(_myContext.Acts).FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<Model.Act> GetActions()
        {
            return FilterExist(_myContext.Acts);
        }

        public IQueryable<Model.Act> GetActiveActions()
        {
            var adminMenus = FilterActive(this.GetActions());
            return adminMenus;
        }

        public IQueryable<Model.Act> GetActions(int ActionCategoryID)
        {
            return this.GetActions().Where(x => x.ActionCategoryID == ActionCategoryID);
        }

        public IQueryable<Model.Act> GetActiveActions(int ActionCategoryID)
        {
            var Actions = FilterActive(GetActions(ActionCategoryID));
            return Actions;
        }

        public PagedResult<Model.Act> GetActions(int ActionCategoryID, int pageNumber, string searchString = "")
        {
            var q = this.GetActions(ActionCategoryID);
            return GetPagedResult(q, pageNumber, searchString);
        }

        public PagedResult<Model.Act> GetActions(int pageNumber, string searchString = "")
        {
            return GetPagedResult(this.GetActions(), pageNumber, searchString);
        }
    }
}
