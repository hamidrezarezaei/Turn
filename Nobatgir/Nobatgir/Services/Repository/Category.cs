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
        public PagedResult<Model.Category> GetCategories(int pageNumber, string searchString = "")
        {
            var data = GetListByParentWithPaging<Category, int>(x => x.SiteID, SiteID, pageNumber, searchString);
            return data;
        }

        //public Model.Category GetCategory(int id)
        //{
        //    return this.GetCategories().FirstOrDefault(x => x.ID == id);
        //}

        //public IQueryable<Model.Category> GetActiveCategorys()
        //{
        //    var r = FilterActive(this.GetCategories());
        //    return r;
        //}

        //public IQueryable<Model.Category> GetCategoriesBySiteID(int SiteID)
        //{
        //    return this.GetCategories().Where(x => x.SiteID == SiteID);
        //}

        //public IQueryable<Model.Category> GetActiveCategoriesBySiteID(int SiteID)
        //{
        //    var r = FilterActive(GetCategoriesBySiteID(SiteID));
        //    return r;
        //}

        //public PagedResult<Model.Category> GetCategoriesBySiteID(int SiteID, int pageNumber, string searchString = "")
        //{
        //    var q = this.GetActiveCategoriesBySiteID(SiteID);
        //    var r = GetPagedResult(q, pageNumber, searchString);
        //    r.Controller = "Category";
        //    return r;
        //}

        //public PagedResult<Model.Category> GetCategories(int pageNumber, string searchString = "")
        //{
        //    return GetPagedResult(this.GetCategories(), pageNumber, searchString);
        //}
    }
}
