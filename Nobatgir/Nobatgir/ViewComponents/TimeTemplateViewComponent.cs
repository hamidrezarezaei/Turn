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
        private readonly Repository repository;

        public TimeTemplateViewComponent(Repository repository)
        {
            this.repository = repository;
        }
        #endregion

        #region Invoke
        public async Task<IViewComponentResult> InvokeAsync(int ExpertID, string ViewName = "Default")
        {
            var lst = new List<TimeTemplateViewModel>();

            lst.Add(new TimeTemplateViewModel
            {
                Day = 1,
                PersianMonth = PersianMonths.بهمن,
                DayOfWeekPersian = DayOfWeekPersians.شنبه,
                Turns = new List<Model.Turn> { new Model.Turn { Time = "8:00" }, new Model.Turn { Time = "10:00" }, new Model.Turn { Time = "12:00" }, new Model.Turn { Time = "15:00" } }
            });

            lst.Add(new TimeTemplateViewModel
            {
                Day = 12,
                PersianMonth = PersianMonths.بهمن,
                DayOfWeekPersian = DayOfWeekPersians.سه_شنبه,
                Turns = new List<Model.Turn> { new Model.Turn { Time = "8:12" }, new Model.Turn { Time = "10:12" }, new Model.Turn { Time = "12:12" } }
            });

            return View(ViewName, lst);
        }

        #endregion 
    }
}
