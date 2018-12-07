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
    public class ActController : BaseController
    {
        #region Constructor
        public ActController(Repository repository) : base(repository)
        {
            this.type = typeof(Model.Act);
        }
        #endregion

        public IActionResult Index(int ActionCategoryID, int pageNumber, string searchString)
        {
            var data = this.repository.GetListByParentWithPaging<Act>(x => x.ActCategoryID, ActionCategoryID, pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Model.Act row, string returnURL)
        {
            return this.EditBase(row, returnURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Model.Act row, string ReturnUrl, int ID)
        {
            return this.CreateBase(row, ReturnUrl);
        }
    }
}