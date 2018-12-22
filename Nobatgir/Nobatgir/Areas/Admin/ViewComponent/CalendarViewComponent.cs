using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Nobatgir.Areas.Admin.ViewModel;
using Nobatgir.Services;
using Nobatgir.Data;
using Nobatgir.Model;

namespace Nobatgir.Areas.Admin
{
    public class CalendarViewComponent : ViewComponent
    {
        #region Constructor
        private readonly Repository _repository;

        public CalendarViewComponent(Repository repository)
        {
            this._repository = repository;
        }
        #endregion

        #region Invoke
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var m = new CalendarViewModel();

            var currentyear = Lib.persianDateTime.GetTodayYear();
            var currentmonth = Lib.persianDateTime.GetTodayMonth();
            var currentday = Lib.persianDateTime.GetTodayDay();

            var year = Request.Query["year"].ToString();
            var month = Request.Query["month"].ToString();

            if (year == "" && month == "")
            {
                m.Year = currentyear;
                m.Month = currentmonth;
                m.Day = currentday;
            }
            else if (year != "" && month != "")
            {
                m.Year = int.Parse(year);
                m.Month = int.Parse(month);

                if (year == currentyear.ToString() && month == currentmonth.ToString())
                    m.Day = currentday;
            }
            else
            {
                throw new Exception("تاریخ اشتباه");
            }

            return View("Default", m);
        }

        #endregion 
    }
}
