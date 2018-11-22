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
        public IQueryable<ActionCategory> GetActionCategories()
        {
            return FilterExist(_myContext.ActionCategories);
        }

        public ActionCategory GetActionCategory(int id)
        {
            return FilterExist(_myContext.ActionCategories).FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<ActionCategory> GetActiveActionCategories()
        {
            var adminMenus = FilterActive(FilterExist(_myContext.ActionCategories.Include(x => x.Actions)));
            return adminMenus;
        }

        public PagedResult<ActionCategory> GetActionCategories(int pageNumber, string searchString = "")
        {
            if (pageNumber == 0)
                pageNumber = 1;

            IEnumerable<ActionCategory> query;

            if (!string.IsNullOrEmpty(searchString))
                query = FilterExist(_myContext.ActionCategories).Where(e => e.Title.Contains(searchString));
            else
                query = FilterExist(_myContext.ActionCategories);

            var result = new PagedResult<ActionCategory>
            {
                PagingData =
                {
                    CurrentPage = pageNumber,
                    ItemsPerPage = pageSize,
                    TotalItems = query.Count()
                },
                Items = query.OrderBy(e => e.OrderIndex).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
            };

            return result;
        }
    }
}
