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
    public class ExpertController : BaseController
    {
        #region Constructor
        public ExpertController(Repository repository) : base(repository)
        {
            this.type = typeof(Model.Expert);
        }
        #endregion

        public IActionResult Index(int pageNumber, string searchString)
        {
            var data = this.repository.GetListByParentWithPaging<Expert>(x => x.CategoryID, this.repository.CategoryID, pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        public override IActionResult Details(int? id, int pageNumber, string searchString, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.repository.GetSingle<Expert>(id.Value);

            var catadminurl = Url.RouteUrl(nameof(MyRoutes.SiteCatExpert), new { expertname = row.Name, controller = "", action = "", id = "" });

            return Redirect(catadminurl);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Model.Expert row, string returnURL)
        {
            return this.EditBase(row, returnURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Model.Expert row, string ReturnUrl, int ID)
        {
            return this.CreateBase(row, ReturnUrl);
        }
    }
}