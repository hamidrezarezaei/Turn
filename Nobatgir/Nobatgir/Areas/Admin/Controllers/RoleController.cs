using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nobatgir.Areas.Admin.ViewModel;
using Nobatgir.Model;
using Nobatgir.Services;

namespace Nobatgir.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : BaseController
    {
        #region Constructor
        public RoleController(Repository repository) : base(repository)
        {
            //this.type = typeof(User);
        }
        #endregion

        public ActionResult Index(int pageNumber, string searchString)
        {
            var rolelist = this.Repository.GetRoleList().Select(x => new RoleViewModel(x));

            var data = this.Repository.GetPagedResult(rolelist.AsQueryable(), pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        public override IActionResult Details(int? id, int pageNumber, string searchString, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.Repository.GetRole(id.Value);

            if (row == null)
                return NotFound();

            var uvm = new RoleViewModel(row);

            return View(new DetailsViewModel<BaseClass> { Row = uvm, ActionType = ActionTypes.Details });
        }

        public override IActionResult Edit(int? id, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.Repository.GetRole(id.Value);

            if (row == null)
                return NotFound();

            ViewBag.ReturnURL = ReturnURL;

            var uvm = new RoleViewModel(row);

            return View(new DetailsViewModel<BaseClass> { Row = uvm, ActionType = ActionTypes.Edit });
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(ActCategory row, string returnURL)
        //{
        //    return this.EditBase(row, returnURL);
        //}

        public override IActionResult Create(string ReturnURL)
        {
            ViewBag.ReturnURL = ReturnURL;

            var uvm = new RoleViewModel();

            var m = new DetailsViewModel<BaseClass> { ActionType = ActionTypes.Create };
            m.Row = uvm;

            return View(m);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RoleViewModel row, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                this.Repository.CreateRole(row.Name, row.Title);

                return RedirectToLocal(ReturnUrl);
            }
            ViewBag.ReturnUrl = ReturnUrl;

            return View(row);
        }
    }
}