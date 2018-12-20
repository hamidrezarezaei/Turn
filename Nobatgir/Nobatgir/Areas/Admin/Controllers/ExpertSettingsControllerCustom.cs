//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.Extensions.Options;
//using Nobatgir.Areas.Admin.ViewModel;
//using Nobatgir.Model;
//using Nobatgir.Services;

//namespace Nobatgir.Areas.Admin.Controllers
//{
//    public class ExpertSettingControllerCustom : BaseController
//    {
//        #region Constructor
//        public ExpertSettingControllerCustom(Repository repository) : base(repository)
//        {
//            this.type = typeof(ExpertSettingViewModel);
//        }
//        #endregion

//        public IActionResult Index(int pageNumber, string searchString)
//        {
//            var list = this.Repository.GetExpertSettings().Select(x => new ExpertSettingViewModel(x));

//            var data = this.Repository.GetPagedResult(list.AsQueryable(), pageNumber, searchString);
//            ViewBag.SearchString = searchString;

//            return View(data);
//        }

//        public override IActionResult Edit(int? id, string ReturnURL)
//        {
//            if (id == null)
//                return NotFound();

//            var exp = this.Repository.GetExpertSetting(id.Value);

//            if (exp == null)
//            {
//                return NotFound();
//            }

//            ViewBag.ReturnURL = ReturnURL;

//            var row = new ExpertSettingViewModel(exp);

//            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Edit });
//        }

//        public override IActionResult Details(int? id, int pageNumber, string searchString, string ReturnURL)
//        {
//            if (id == null)
//                return NotFound();

//            var exp = this.Repository.GetExpertSetting(id.Value);

//            var row = new ExpertSettingViewModel(exp);

//            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Details });
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Edit(ExpertSettingViewModel row, string returnURL)
//        {
//            if (ModelState.IsValid)
//            {
//                row.ExpertSetting.ExpertID = this.Repository.ExpertID;
//                row.ExpertSetting.ID = row.ID;

//                this.Repository.UpdateExpertSettings(row.ExpertSetting);

//                return RedirectToLocal(returnURL);
//            }

//            ViewBag.ReturnUrl = returnURL;
//            return View(row);
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Create(ExpertSettingViewModel row, string ReturnUrl)
//        {
//            if (ModelState.IsValid)
//            {
//                row.ExpertSetting.ExpertID = this.Repository.ExpertID;

//                Repository.AddExpertSettings(row.ExpertSetting);

//                return RedirectToLocal(ReturnUrl);
//            }

//            ViewBag.ReturnUrl = ReturnUrl;

//            return View(row);
//        }
//    }
//}