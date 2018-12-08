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
            var data = this.repository.GetListWithPaging<Site>(pageNumber, searchString, x=>x.SiteKind);
            ViewBag.SearchString = searchString;

            data.DisplayColumns.Add("SiteKindTitle");

            return View(data);
        }

        public override IActionResult Details(int? id, int pageNumber, string searchString, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.repository.GetSingle<Site>(id.Value, x => x.SiteKind);
            var r = this.repository.GetListByParentWithPaging<Category>(x => x.SiteID, id.Value, pageNumber, searchString);
            r.Controller = "Category";
            ViewBag.Categories = r;

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