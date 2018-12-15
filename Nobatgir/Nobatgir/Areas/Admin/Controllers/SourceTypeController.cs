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
    public class SourceTypeController : BaseController
    {
        #region Constructor
        public SourceTypeController(Repository repository) : base(repository)
        {
            this.type = typeof(SourceType);
        }
        #endregion

        public IActionResult Index(int pageNumber, string searchString)
        {
            var data = this.Repository.GetListWithPaging<SourceType>(pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        public override IActionResult Details(int? id, int pageNumber, string searchString, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.Repository.GetSingle<SourceType>(id.Value);

            var r  = this.Repository.GetListByParentWithPaging<SourceValue, int>(x => x.SourceTypeID, id.Value, pageNumber, searchString);
            r.Controller = "SourceValue";
            ViewBag.SourceValues = r;

            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Details });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SourceType row, string returnURL)
        {
            return this.EditBase(row, returnURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SourceType row, string ReturnUrl)
        {
            return this.CreateBase(row, ReturnUrl);
        }
    }
}