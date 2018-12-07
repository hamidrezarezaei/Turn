using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nobatgir.Data;
using Nobatgir.ViewModel;

namespace Nobatgir.Services
{
    public partial class Repository
    {
        //public Model.Expert GetExpert(int id)
        //{
        //    return FilterExist(_myContext.Experts).FirstOrDefault(x => x.ID == id);
        //}

        //public IQueryable<Model.Expert> GetExperts()
        //{
        //    return FilterExist(_myContext.Experts);
        //}

        //public IQueryable<Model.Expert> GetActiveExperts()
        //{
        //    var r = FilterActive(this.GetExperts());
        //    return r;
        //}

        //public IQueryable<Model.Expert> GetExperts(int CategoryID)
        //{
        //    return this.GetExperts().Where(x => x.CategoryID == CategoryID);
        //}

        //public IQueryable<Model.Expert> GetActiveExperts(int SiteID)
        //{
        //    var r = FilterActive(GetExperts(SiteID));
        //    return r;
        //}

        //public PagedResult<Model.Expert> GetExperts(int SiteID, int pageNumber, string searchString = "")
        //{
        //    var q = this.GetExperts(SiteID);
        //    var r = GetPagedResult(q, pageNumber, searchString);
        //    r.Controller = "Expert";
        //    return r;
        //}

        //public PagedResult<Model.Expert> GetExperts(int pageNumber, string searchString = "")
        //{
        //    return GetPagedResult(this.GetExperts(), pageNumber, searchString);
        //}
    }
}
