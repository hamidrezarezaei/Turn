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
        public IQueryable<Model.Action> GetActions()
        {
            return FilterExist(_myContext.Actions);
        }

        public PagedResult<Model.Action> GetActions(int ActionCategoryID, int pageNumber, string searchString = "")
        {
            var q = FilterExist(_myContext.Actions).Where(x => x.ActionCategoryID == ActionCategoryID);

            return GetPagedResult(q, pageNumber, searchString);
        }

        public IQueryable<Model.Action> GetActiveActions()
        {
            var adminMenus = FilterActive(FilterExist(_myContext.Actions));
            return adminMenus;
        }

        public PagedResult<Model.Action> GetActions(int pageNumber, string searchString = "")
        {
            return GetPagedResult(_myContext.Actions, pageNumber, searchString);

            //if (pageNumber == 0)
            //    pageNumber = 1;

            //IEnumerable<Model.Action> query;

            //if (!string.IsNullOrEmpty(searchString))
            //    query = FilterExist(_myContext.Actions).Where(e => e.Title.Contains(searchString));
            //else
            //    query = FilterExist(_myContext.Actions);

            //var result = new PagedResult<Model.Action>
            //{
            //    PagingData =
            //    {
            //        CurrentPage = pageNumber,
            //        ItemsPerPage = pageSize,
            //        TotalItems = query.Count()
            //    },
            //    Items = query.OrderBy(e => e.OrderIndex).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
            //};

            //return result;
        }
    }
}
