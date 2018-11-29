using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nobatgir.Data;
using Nobatgir.Model;
using Nobatgir.ViewModel;

namespace Nobatgir.Services
{
    public partial class Repository
    {
        public Model.ActCategory GetActCategory(int id)
        {
            return FilterExist(_myContext.ActCategories).FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<Model.ActCategory> GetActiveActCategories()
        {
            var adminMenus = FilterActive(FilterExist(_myContext.ActCategories.Include(x => x.Acts)));
            return adminMenus;
        }

        public IQueryable<ActCategory> GetActCategories()
        {
            return FilterExist(_myContext.ActCategories);
        }

        public PagedResult<ActCategory> GetActCategories(int pageNumber, string searchString = "")
        {
            var q = this.GetActCategories();
            return GetPagedResult(q, pageNumber, searchString);
        }
    }
}
