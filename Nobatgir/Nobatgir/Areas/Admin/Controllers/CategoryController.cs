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
    public class CategoryController : BaseController
    {
        #region Constructor
        public CategoryController(Repository repository) : base(repository)
        {
            this.type = typeof(Model.Category);
        }
        #endregion

        public IActionResult Index(int SiteID, int pageNumber, string searchString)
        {
            var data = this.repository.GetListByParentWithPaging<Category>(x => x.SiteID, SiteID, pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Model.Category row, string returnURL)
        {
            return this.EditBase(row, returnURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Model.Category row, string ReturnUrl, int ID)
        {
            return this.CreateBase(row, ReturnUrl);
        }
    }
}