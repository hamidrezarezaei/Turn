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
    public class ExpertSettingController : BaseController
    {
        #region Constructor
        public ExpertSettingController(Repository repository) : base(repository)
        {
            this.type = typeof(ExpertSetting);
        }
        #endregion

        public IActionResult Index(int pageNumber, string searchString)
        {
            var data = this.Repository.GetListByParentWithPaging<ExpertSetting, int>(x => x.ExpertID, Repository.ExpertID, pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Model.ExpertSetting row, string returnURL)
        {
            row.ExpertID = Repository.ExpertID;

            return this.EditBase(row, returnURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Model.ExpertSetting row, string ReturnUrl, int ID)
        {
            row.ExpertID = Repository.ExpertID;

            return this.CreateBase(row, ReturnUrl);
        }
    }
}