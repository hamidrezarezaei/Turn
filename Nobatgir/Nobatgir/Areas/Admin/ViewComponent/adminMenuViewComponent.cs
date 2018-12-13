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
        private readonly Repository _repository;

        public AdminMenuViewComponent(Repository repository)
        {
            this._repository = repository;
        }
        #endregion

        #region Invoke
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _repository.GetAdminMenuList();

            return View("Default", items);
        }

        #endregion 
    }
}
