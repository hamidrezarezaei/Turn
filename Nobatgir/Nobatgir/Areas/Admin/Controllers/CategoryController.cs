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

        public IActionResult Index(int pageNumber, string searchString)
        {
            //var data = this.repository.GetListByParentWithPaging<Category>(x => x.SiteID, SiteID, pageNumber, searchString);

            var data = this.repository.GetCategories(pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        public override IActionResult Details(int? id, int pageNumber, string searchString, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.repository.GetSingle<Category>(id.Value);
            var r = this.repository.GetListByParentWithPaging<Expert>(x => x.CategoryID, id.Value, pageNumber, searchString);
            r.Controller = "Expert";
            ViewBag.Experts = r;

            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Details });
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