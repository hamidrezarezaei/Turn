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

        public IActionResult Index(int CategoryID, int pageNumber, string searchString)
        {
            var data = this.repository.GetListByParentWithPaging<Expert>(x => x.CategoryID, CategoryID, pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
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