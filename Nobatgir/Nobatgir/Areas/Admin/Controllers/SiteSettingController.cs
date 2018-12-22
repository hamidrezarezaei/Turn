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
    public class SiteSettingController : BaseController
    {
        #region Constructor
        public SiteSettingController(Repository repository) : base(repository)
        {
            this.type = typeof(SiteSetting);
        }
        #endregion

        public IActionResult Index(int pageNumber, string searchString)
        {
            var data = this.Repository.GetListByParentWithPaging<SiteSetting, int>(x => x.SiteID, Repository.SiteID, pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Model.SiteSetting row, string returnURL)
        {
            row.SiteID = Repository.SiteID;

            return this.EditBase(row, returnURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Model.SiteSetting row, string ReturnUrl, int ID)
        {
            row.SiteID = Repository.SiteID;

            return this.CreateBase(row, ReturnUrl);
        }
    }
}