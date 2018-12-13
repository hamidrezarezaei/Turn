using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Nobatgir.Services;
using Microsoft.AspNetCore.Mvc.Filters;
using Nobatgir.Model;

namespace Nobatgir.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "nobatpolicy")]
    public class BaseController : Controller
    {



        #region Controller
        protected Type type;

        protected readonly Repository Repository;
        public BaseController(Repository repository)
        {
            this.Repository = repository;
        }
        #endregion

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            // اضافی
            //var ControllerName = new Regex("[.](\\w+)Controller").Match(base.ToString()).Groups[1].Value;
            ViewBag.ReturnURL = Url.Action("Index", this.ControllerContext.ActionDescriptor.ControllerName);
        }

        public virtual IActionResult Details(int? id, int pageNumber, string searchString, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.Repository.GetRow(id, this.type);
            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Details });
        }

        public virtual IActionResult Create(string ReturnURL)
        {
            ViewBag.ReturnURL = ReturnURL;

            var m = new DetailsViewModel<BaseClass> {ActionType = ActionTypes.Create};
            m.Row = (BaseClass) Activator.CreateInstance(this.type);

            return View(m);
        }

        public virtual IActionResult Edit(int? id, string ReturnURL)
        {
            var row = this.Repository.GetRow(id, this.type);
            if (row == null)
            {
                return NotFound();
            }
            ViewBag.ReturnURL = ReturnURL;

            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Edit });
        }

        public virtual IActionResult Delete(int? id, string ReturnURL)
        {
            var row = this.Repository.GetRow(id, this.type);
            if (row == null)
            {
                return NotFound();
            }

            ViewBag.ReturnURL = ReturnURL;
            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Delete });
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual IActionResult DeleteConfirmed(int id, string ReturnURL)
        {
            var row = this.Repository.GetRow(id, type);
            this.Repository.DeleteRow(row);
            return RedirectToLocal(ReturnURL);
        }

        protected IActionResult EditBase(BaseClass row, string returnURL)
        {
            if (ModelState.IsValid)
            {
                this.Repository.UpdateRow(row);
                return RedirectToLocal(returnURL);
            }

            ViewBag.ReturnUrl = returnURL;
            return View(row);
        }
        protected IActionResult CreateBase<T>(T row, string ReturnUrl) where T : BaseClass
        {
            if (ModelState.IsValid)
            {
                Repository.AddRow(row);
                return RedirectToLocal(ReturnUrl);
            }
            ViewBag.ReturnUrl = ReturnUrl;

            return View(row);
        }
        public virtual IActionResult RedirectToLocal(string ReturnURL)
        {
            if (Url.IsLocalUrl(ReturnURL))
            {
                return Redirect(ReturnURL);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
    }
}
