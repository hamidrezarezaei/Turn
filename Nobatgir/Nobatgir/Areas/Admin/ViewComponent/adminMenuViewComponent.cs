using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var items = repository.GetActiveActionCategories();
        
            return View("Default", items);
        }
        #endregion 
    }
}
