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
    public class HomeController : Controller
    {
        private readonly Repository _repository;

        public HomeController(Repository repository)
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
            return View(this.GetViewName("index"));
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult AddTurn(string time, DateTime turndate)
        {
            var t = _repository.AddTurn(turndate, time);

            return View(this.GetViewName("AddTurn"), t.ID);
        }

        public IActionResult VerifyTurn(TurnFieldsViewModel f)
        {
            return View(this.GetViewName("VerifyTurn"));
        }

        public IActionResult CancelTurn(TurnFieldsViewModel f)
        {
            var turnid = f.Turn.ID;

            return View(this.GetViewName("VerifyTurn"));
        }

        public IActionResult Category(int ID)
        {
            return View(this.GetViewName("Category"));
        }
    }
}