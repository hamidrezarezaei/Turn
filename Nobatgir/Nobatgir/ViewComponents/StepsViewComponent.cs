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
    public class StepsViewComponent : ViewComponent
    {
        #region Constructor
        private readonly Repository _repository;

        public StepsViewComponent(Repository repository)
        {
            this._repository = repository;
        }
        #endregion

        #region Invoke
        public async Task<IViewComponentResult> InvokeAsync(string ViewName = "Default")
        {
            var s = new StepsViewModel();

            s.CurrentStep = 0;

            switch (_repository.GetActionName.ToLower())
            {
                case "addturn":
                    s.CurrentStep = 1;
                    break;
                case "verifyturn":
                    s.CurrentStep = 2;
                    break;
                case "verified":
                    s.CurrentStep = 3;
                    break;
            }

            s.StepNames.Add("انتخاب ساعت");
            s.StepNames.Add("تکمیل اطلاعات");
            s.StepNames.Add("پایان");

            return View(ViewName, s);
        }

        #endregion 
    }
}
