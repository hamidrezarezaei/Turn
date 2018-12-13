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
    public class AdminMenuController : BaseController
    {
        #region Constructor
        public AdminMenuController(Repository repository) : base(repository)
        {
            this.type = typeof(Model.AdminMenu);
        }
        #endregion

        public IActionResult Index(SiteKinds SiteKindID, int pageNumber, string searchString)
        {
            var data = this.Repository.GetListByParentWithPaging<AdminMenu, SiteKinds>(x => x.SiteKindEnum, SiteKindID, pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Model.AdminMenu row, string returnURL)
        {
            return this.EditBase(row, returnURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Model.AdminMenu row, string ReturnUrl, int ID)
        {
            return this.CreateBase(row, ReturnUrl);
        }
    }
}