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
    public class ActionCategoryController : BaseController
    {
        #region Constructor
        public ActionCategoryController(Repository repository) : base(repository)
        {
            this.type = typeof(ActionCategory);
        }
        #endregion

        public IActionResult Index(int pageNumber, string searchString)
        {
            var data = this.repository.GetActionCategories(pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        public override IActionResult Details(int? id, int pageNumber, string searchString)
        {
            if (id == null)
                return NotFound();

            var row = this.repository.GetActionCategory(id.Value);
            ViewBag.Actions = this.repository.GetActions(id.Value, pageNumber, searchString);

            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Details });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ActionCategory row, string returnURL)
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
        public IActionResult Create(ActionCategory row, string ReturnUrl)
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