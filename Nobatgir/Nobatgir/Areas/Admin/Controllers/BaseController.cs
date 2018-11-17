using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nobatgir.Services;
using Nobatgir.Util;

namespace Nobatgir.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BaseController: Controller
    {
        #region Controller
        protected Type type;

        protected readonly Repository repository;
        public BaseController(Repository repository)
        {
            this.repository = repository;
        }
        #endregion

        public IActionResult Create(ReturnUrl ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }
        public IActionResult Edit(int? id, ReturnUrl ReturnUrl)
        {
            var row = this.repository.GetRow(id, this.type);
            if (row == null)
            {
                return NotFound();
            }
            ViewBag.ReturnUrl = ReturnUrl;
            return View(row);
        }

        public IActionResult Delete(int? id, ReturnUrl ReturnUrl)
        {
            var row = this.repository.GetRow(id,this.type);
            if (row == null)
            {
                return NotFound();
            }

            ViewBag.ReturnUrl = ReturnUrl;
            return View(row);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id, ReturnUrl ReturnUrl)
        {
            var row = this.repository.GetRow(id, type);
            this.repository.DeleteRow(row);
            return RedirectToLocal(ReturnUrl);
        }

        public IActionResult RedirectToLocal(ReturnUrl ReturnUrl)
        {
            if (Url.IsLocalUrl(ReturnUrl.Url))
            {
                return Redirect(ReturnUrl.Url);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
    }
}
