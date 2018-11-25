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
    public class ActionController : BaseController
    {
        #region Constructor
        public ActionController(Repository repository) : base(repository)
        {
            this.type = typeof(Model.Action);
        }
        #endregion

        public IActionResult Index(int ActionCategoryID,int pageNumber, string searchString)
        {
            var data = this.repository.GetActions(ActionCategoryID, pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Model.Action row, string returnURL)
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
        public IActionResult Create(Model.Action row, string ReturnUrl)
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