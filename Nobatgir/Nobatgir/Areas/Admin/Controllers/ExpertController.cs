using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nobatgir.Model;
using Nobatgir.Services;

namespace Nobatgir.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExpertController : BaseController
    {
        #region Constructor
        public ExpertController(Repository repository) : base(repository)
        {
            this.type = typeof(Expert);
        }
        #endregion

        public IActionResult Index(int pageNumber, string searchString)
        {
            var data = this.repository.GetExperts(pageNumber, searchString);
            ViewBag.SearchString = searchString;

            ViewBag.SiteList = new SelectList(this.repository.GetSites(), "ID", "Title");

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Site row, string returnURL)
        {
            if (ModelState.IsValid)
            {
                this.repository.UpdateRow(row);
                return RedirectToLocal(returnURL);
            }

            ViewBag.ReturnUrl = returnURL;
            return View(row);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Site row, string ReturnUrl)
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