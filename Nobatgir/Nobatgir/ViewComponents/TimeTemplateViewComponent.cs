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
    public class TimeTemplateViewComponent : ViewComponent
    {
        #region Constructor
        private readonly Repository _repository;

        public TimeTemplateViewComponent(Repository repository)
        {
            this._repository = repository;
        }
        #endregion

        #region Invoke
        public async Task<IViewComponentResult> InvokeAsync(string ViewName = "Default")
        {
            var lst = _repository.GetTimeTemplates();

            return View(ViewName, lst);
        }

        #endregion 
    }
}
