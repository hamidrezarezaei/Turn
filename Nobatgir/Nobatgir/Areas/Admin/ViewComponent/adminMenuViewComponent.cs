using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Nobatgir.Services;
using Nobatgir.Data;
using Nobatgir.Model;

namespace Nobatgir.Areas.Admin
{
    public class AdminMenuViewComponent : ViewComponent
    {
        #region Constructor
        private readonly Repository repository;

        public AdminMenuViewComponent(Repository repository)
        {
            this.repository = repository;
        }
        #endregion

        #region Invoke
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var items = repository.GetListActive<ActCategory>(x => x.Acts);
            //var items = from x in repository._myContext.ActCategories
            //            join y in repository._myContext.Acts on x.ID equals y.ActCategoryID
            //            select x;

            //var items = repository.GetListActive<ActCategory>(x => x.Acts).Select(aaa);


            var items = repository.GetListActive<ActCategory>().Select(x => new ActCategory
            {
                ID = x.ID,
                Title = x.Title,
                //Name = x.Acts.GetType().FullName,
                //Acts = repository.FilterExistEnum(x.Acts)
                Acts = x.Acts.Where(y => !y.IsDeleted)
            }).ToList();

            return View("Default", items);
        }

        //private ActCategory aaa(ActCategory x)
        //{
        //    return new ActCategory
        //    {
        //        ID = x.ID,
        //        Title = x.Title,
        //        Name = x.Name,
        //        Acts = repository.FilterExistEnum(x.Acts)
        //    };
        //}

        #endregion 
    }
}
