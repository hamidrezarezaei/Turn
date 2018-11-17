using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nobatgir.Model;
using Nobatgir.Services;
using Nobatgir.Util;

namespace Nobatgir.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SiteController : BaseController
    {
        #region Constructor
        public SiteController(Repository repository) : base(repository)
        {
            this.type = typeof(Site);
        }
        #endregion

        public IActionResult Index(int pageNumber, string searchString)
        {
            var data = this.repository.GetEntities(pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Site row, ReturnUrl returnUrl)
        {
            if (ModelState.IsValid)
            {
                this.repository.UpdateRow(row);
                return RedirectToLocal(returnUrl);
            }

            ViewBag.ReturnUrl = returnUrl;
            return View(row);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Site row, ReturnUrl ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                repository.AddRow(row);
                return RedirectToLocal(ReturnUrl);
            }
            ViewBag.ReturnUrl = ReturnUrl;

            return View(row);
        }
    }
}