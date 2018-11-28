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
        public Model.ActCategory GetActionCategory(int id)
        {
            return FilterExist(_myContext.ActCategories).FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<Model.ActCategory> GetActiveActionCategories()
        {
            var adminMenus = FilterActive(FilterExist(_myContext.ActCategories.Include(x => x.Acts)));
            return adminMenus;
        }

        public IQueryable<ActCategory> GetActionCategories()
        {
            return FilterExist(_myContext.ActCategories);
        }
        
        public PagedResult<ActCategory> GetActionCategories(int pageNumber, string searchString = "")
        {
            var q = this.GetActionCategories();
            return GetPagedResult(q, pageNumber, searchString);
        }
    }
}
