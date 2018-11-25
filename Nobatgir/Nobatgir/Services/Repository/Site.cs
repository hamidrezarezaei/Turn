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
        public Site GetSite(int id)
        {
            return FilterExist(_myContext.Sites).FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<Site> GetSites()
        {
            return FilterExist(_myContext.Sites);
        }

        public IQueryable<Site> GetActiveSites()
        {
            var adminMenus = FilterActive(this.GetSites());
            return adminMenus;
        }

        public PagedResult<Site> GetSites(int pageNumber, string searchString = "")
        {
            var q = this.GetSites();
            return GetPagedResult(q, pageNumber, searchString);
        }
    }
}
