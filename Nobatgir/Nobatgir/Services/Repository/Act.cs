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

        //public IQueryable<Model.Act> GetActs(int ActCategoryID)
        //{
        //    return this.GetActs().Where(x => x.ActCategoryID == ActCategoryID);
        //}


        //public Model.Act GetAct(int id)
        //{
        //    return FilterExist(_myContext.Acts).FirstOrDefault(x => x.ID == id);
        //}

        //public IQueryable<Model.Act> GetActs()
        //{
        //    return FilterExist(_myContext.Acts);
        //}

        //public IQueryable<Model.Act> GetActiveActs()
        //{
        //    var adminMenus = FilterActive(this.GetActs());
        //    return adminMenus;
        //}

        //public IQueryable<Model.Act> GetActiveActs(int ActCategoryID)
        //{
        //    var Actions = FilterActive(GetActs(ActCategoryID));
        //    return Actions;
        //}

        //public PagedResult<Model.Act> GetActs(int ActionCategoryID, int pageNumber, string searchString = "")
        //{
        //    var q = this.GetActs(ActionCategoryID);
        //    var r = GetPagedResult(q, pageNumber, searchString);
        //    r.Controller = "Act";
        //    return r;
        //}

        //public PagedResult<Model.Act> GetActs(int pageNumber, string searchString = "")
        //{
        //    return GetPagedResult(this.GetActs(), pageNumber, searchString);
        //}
    }
}
