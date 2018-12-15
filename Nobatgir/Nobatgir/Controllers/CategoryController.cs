using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Nobatgir.Model;
using Nobatgir.Services;
using Nobatgir.ViewModel;

namespace Nobatgir.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Repository _repository;

        public CategoryController(Repository repository)
        {
            _repository = repository;
        }

        private string GetViewName(string pagename)
        {
            var viewname = this._repository.GetSiteKindSetting(Settings.ViewName);

            ViewBag.Title = this._repository.GetSiteSetting(Settings.SiteTitle);
            ViewBag.ViewName = viewname;

            return "/Views/" + viewname + "/" + pagename + ".cshtml";
        }

        public IActionResult Index()
        {
            return View(this.GetViewName("category"));
        }
    }
}