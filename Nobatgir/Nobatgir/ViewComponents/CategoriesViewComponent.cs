using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Nobatgir.Services;
using Nobatgir.Data;
using Nobatgir.Model;
using Nobatgir.ViewModel;

namespace Nobatgir.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        #region Constructor
        private readonly Repository _repository;

        public CategoriesViewComponent(Repository repository)
        {
            this._repository = repository;
        }
        #endregion

        #region Invoke
        public async Task<IViewComponentResult> InvokeAsync(string ViewName = "Default")
        {
            var cats = _repository.GetListActiveByParent<Category, int>(x => x.SiteID, _repository.SiteID);

            return View(ViewName, cats);
        }

        #endregion 
    }
}
