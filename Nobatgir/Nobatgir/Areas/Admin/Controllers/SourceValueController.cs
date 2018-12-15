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
    public class SourceValueController : BaseController
    {
        #region Constructor
        public SourceValueController(Repository repository) : base(repository)
        {
            this.type = typeof(Model.SourceValue);
        }
        #endregion

        public IActionResult Index(int SourceTypeID, int pageNumber, string searchString)
        {
            var data = this.Repository.GetListByParentWithPaging<SourceValue, int>(x => x.SourceTypeID, SourceTypeID, pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Model.SourceValue row, string returnURL)
        {
            row.SourceTypeID = int.Parse(RouteData.Values["id"].ToString());

            return this.EditBase(row, returnURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Model.SourceValue row, string ReturnUrl, int ID)
        {
            row.SourceTypeID = int.Parse(RouteData.Values["id"].ToString());

            var sourcetype = Repository.GetSingle<SourceType>(row.SourceTypeID);
            if (sourcetype.ExpertID != this.Repository.ExpertID)
            {
                throw new Exception("خطا");
            }

            return this.CreateBase(row, ReturnUrl);
        }
    }
}