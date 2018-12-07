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
      

        //public IQueryable<Site> GetSites()
        //{
        //    return FilterExist(_myContext.Sites.Include(x => x.SiteKind));
        //}

        //public Site GetSite(int id)
        //{
        //    return GetSites().FirstOrDefault(x => x.ID == id);
        //}

        //public PagedResult<Site> GetSites(int pageNumber, string searchString = "")
        //{
        //    var q = this.GetSites();
        //    return GetPagedResult(q, pageNumber, searchString);
        //}
    }
}
