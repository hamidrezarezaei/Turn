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
            var data = this.Repository.GetListWithPaging<Site>(pageNumber, searchString, x=>x.SiteKind);
            ViewBag.SearchString = searchString;

            data.DisplayColumns.Add("SiteKindTitle");

            return View(data);
        }

        public override IActionResult Details(int? id, int pageNumber, string searchString, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.Repository.GetSingle<Site>(id.Value);

            var url = Url.RouteUrl(nameof(MyRoutes.Site), new { sitename = row.Name, controller = "", action = "", id = "" });

            return Redirect(url);


            //if (id == null)
            //    return NotFound();

            //var row = this.Repository.GetSingle<Site>(id.Value, x => x.SiteKind);
            //var r = this.Repository.GetListByParentWithPaging<Category>(x => x.SiteID, id.Value, pageNumber, searchString);
            //r.Controller = "Category";
            //ViewBag.Categories = r;

            //return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Details });
        }

        public override IActionResult Create(string ReturnURL)
        {
            var r = base.Create(ReturnURL);

            ViewBag.SiteKindsCombo = new SelectList(this.Repository.GetListActive<SiteKind>(), "ID", "Title");

            return r;
        }

        public override IActionResult Edit(int? id, string ReturnURL)
        {
            var r = base.Edit(id, ReturnURL);

            ViewBag.SiteKindsCombo = new SelectList(this.Repository.GetListActive<SiteKind>(), "ID", "Title");

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
            var r = this.CreateBase(row, ReturnUrl);

            var c = Repository.AddDefaultCategory(row.ID, row.Title, row.Name);
            Repository.AddDefaultExpert(c.ID, row.Title, row.Name);

            return r;
        }
    }
}