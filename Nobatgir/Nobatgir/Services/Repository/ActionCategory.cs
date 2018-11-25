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
        public Model.ActionCategory GetActionCategory(int id)
        {
            return FilterExist(_myContext.ActionCategories).FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<Model.ActionCategory> GetActiveActionCategories()
        {
            var adminMenus = FilterActive(FilterExist(_myContext.ActionCategories.Include(x => x.Actions)));
            return adminMenus;
        }

        public IQueryable<ActionCategory> GetActionCategories()
        {
            return FilterExist(_myContext.ActionCategories);
        }
        
        public PagedResult<ActionCategory> GetActionCategories(int pageNumber, string searchString = "")
        {
            var q = this.GetActionCategories();
            return GetPagedResult(q, pageNumber, searchString);
        }
    }
}
