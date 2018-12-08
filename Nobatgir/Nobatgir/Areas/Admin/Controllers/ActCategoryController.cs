using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Nobatgir.Model;
using Nobatgir.Services;

namespace Nobatgir.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActCategoryController : BaseController
    {
        #region Constructor
        public ActCategoryController(Repository repository) : base(repository)
        {
            this.type = typeof(ActCategory);
        }
        #endregion

        public IActionResult Index(int pageNumber, string searchString)
        {
            var data = this.repository.GetListWithPaging<ActCategory>(pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        public override IActionResult Details(int? id, int pageNumber, string searchString, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.repository.GetSingle<ActCategory>(id.Value);

            var r  = this.repository.GetListByParentWithPaging<Act>(x => x.ActCategoryID, id.Value, pageNumber, searchString);
            r.Controller = "Act";
            ViewBag.Acts = r;

            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Details });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ActCategory row, string returnURL)
        {
            return this.EditBase(row, returnURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ActCategory row, string ReturnUrl)
        {
            return this.CreateBase(row, ReturnUrl);
        }
    }
}