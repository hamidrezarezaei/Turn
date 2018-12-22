using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nobatgir.Areas.Admin.ViewModel;
using Nobatgir.Model;
using Nobatgir.Services;

namespace Nobatgir.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "nobatpolicy")]
    public class TurnCalendarController : Controller
    {
        private readonly Repository _repository;

        public TurnCalendarController(Repository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ShowDay(int year, int month, int day)
        {
            var p = new System.Globalization.PersianCalendar();
            var dt = p.ToDateTime(year, month, day, 0, 0, 0, 0);

            var times = _repository.GetTimeTemplatesTimes(dt.DayOfWeek).Select(x => new Turn { Time = x }).ToList();

            var turns = _repository.GetTurnsOfDate(dt)
                .Include(x => x.TurnDetails)
                .ThenInclude(x => x.ExpertField)
                .ThenInclude(x => x.SourceType)
                .ThenInclude(x => x.SourceValues)
                .ToList();

            var idMap = times.Union(turns).ToLookup(x => x.Time);
            var q = idMap.Select(x => x.FirstOrDefault(y => y.ID != Guid.Empty) ?? x.First());

            var m = new CalendarShowDayViewModel { Date = Lib.persianDateTime.PersianDateStringFormat(dt), Turns = q };

            return View(m);
        }
    }
}