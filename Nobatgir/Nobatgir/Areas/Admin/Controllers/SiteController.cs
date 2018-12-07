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
    public class SiteController : BaseController
    {
        #region Constructor
        public SiteController(Repository repository) : base(repository)
        {
            this.type = typeof(Site);
        }
        #endregion

        public IActionResult Index(int pageNumber, string searchString)
        {
            var data = this.repository.GetListWithPaging<Site>(pageNumber, searchString);
            ViewBag.SearchString = searchString;

            var t = repository.Translate(Terms.Expert);

            return View(data);
        }

        public override IActionResult Details(int? id, int pageNumber, string searchString, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.repository.GetSingle<Site>(id.Value, x => x.SiteKind);
            ViewBag.Categories = this.repository.GetListByParentWithPaging<Category>(x => x.SiteID, id.Value, pageNumber, searchString);

            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Details });
        }

        public override IActionResult Create(string ReturnURL)
        {
            var r = base.Create(ReturnURL);

            ViewBag.SiteKindsCombo = new SelectList(this.repository.GetListActive<SiteKind>(), "ID", "Title");

            return r;
        }

        public override IActionResult Edit(int? id, string ReturnURL)
        {
            var r = base.Edit(id, ReturnURL);

            ViewBag.SiteKindsCombo = new SelectList(this.repository.GetListActive<SiteKind>(), "ID", "Title");

            return r;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Site row, string returnURL)
        {
            return this.EditBase(row, returnURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Site row, string ReturnUrl)
        {
            return this.CreateBase(row, ReturnUrl);
        }
    }
}