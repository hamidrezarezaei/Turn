using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Nobatgir.Model;
using Nobatgir.Services;

namespace Nobatgir.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SiteTimeTemplateController : BaseController
    {
        #region Constructor
        public SiteTimeTemplateController(Repository repository) : base(repository)
        {
            this.type = typeof(SiteTimeTemplate);
        }
        #endregion

        public IActionResult Index(int pageNumber, string searchString)
        {
            var data = this.repository.GetListWithPaging<SiteTimeTemplate>(pageNumber, searchString);
            ViewBag.SearchString = searchString;

            data.DisplayColumns.Add("WeekDayName");

            return View(data);
        }
        public override IActionResult Create(string ReturnURL)
        {
            var r = base.Create(ReturnURL);

            ViewBag.WeekDayCombo = new SelectList(DayOfWeekPersian.GetList(), "ID", "WeekDay");

            return r;
        }

        public override IActionResult Edit(int? id, string ReturnURL)
        {
            var r = base.Edit(id, ReturnURL);

            ViewBag.WeekDayCombo = new SelectList(DayOfWeekPersian.GetList(), "ID", "WeekDay");

            return r;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SiteTimeTemplate row, string returnURL)
        {
            return this.EditBase(row, returnURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SiteTimeTemplate row, string ReturnUrl)
        {
            return this.CreateBase(row, ReturnUrl);
        }
    }
}