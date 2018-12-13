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
    public class ExpertFieldController : BaseController
    {
        #region Constructor
        public ExpertFieldController(Repository repository) : base(repository)
        {
            this.type = typeof(ExpertField);
        }
        #endregion

        public IActionResult Index(int pageNumber, string searchString)
        {
            var data = this.Repository.GetListWithPaging<ExpertField>(pageNumber, searchString);
            ViewBag.SearchString = searchString;

            //data.DisplayColumns.Add("SiteKindTitle");

            return View(data);
        }

        public override IActionResult Details(int? id, int pageNumber, string searchString, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.Repository.GetSingle<ExpertField>(id.Value);
            var r = this.Repository.GetListByParentWithPaging<ExpertField, int>(x => x.ExpertID, id.Value, pageNumber, searchString);
            r.Controller = "ExpetField";
            ViewBag.Categories = r;

            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Details });
        }

        public override IActionResult Create(string ReturnURL)
        {
            var r = base.Create(ReturnURL);

            ViewBag.FieldTypesCombo = new SelectList(FieldType.GetList(), "ID", "Name");
            ViewBag.SourceTypesCombo = new SelectList(this.Repository.GetListActive<SourceType>(), "ID", "Title");

            return r;
        }

        public override IActionResult Edit(int? id, string ReturnURL)
        {
            var r = base.Edit(id, ReturnURL);

            ViewBag.FieldTypesCombo = new SelectList(FieldType.GetList(), "ID", "Name");
            ViewBag.SourceTypesCombo = new SelectList(this.Repository.GetListActive<SourceType>(), "ID", "Title");

            return r;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ExpertField row, string returnURL)
        {
            row.ExpertID = this.Repository.ExpertID;

            return this.EditBase(row, returnURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpertField row, string ReturnUrl)
        {
            row.ExpertID = this.Repository.ExpertID;

            return this.CreateBase(row, ReturnUrl);
        }
    }
}