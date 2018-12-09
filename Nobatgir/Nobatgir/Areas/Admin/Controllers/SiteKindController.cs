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
    public class SiteKindController : BaseController
    {
        #region Constructor
        public SiteKindController(Repository repository) : base(repository)
        {
            this.type = typeof(SiteKind);
        }
        #endregion

        public IActionResult Index(int pageNumber, string searchString)
        {
            var data = this.repository.GetListWithPaging<SiteKind>(pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        public override IActionResult Details(int? id, int pageNumber, string searchString, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.repository.GetSingle<SiteKind>(id.Value);

            var r  = this.repository.GetListByParentWithPaging<AdminMenu>(x => x.SiteKindID, id.Value, pageNumber, searchString);
            r.Controller = "AdminMenu";
            ViewBag.Menus = r;

            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Details });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SiteKind row, string returnURL)
        {
            return this.EditBase(row, returnURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SiteKind row, string ReturnUrl)
        {
            return this.CreateBase(row, ReturnUrl);
        }
    }
}