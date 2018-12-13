using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nobatgir.Services;

namespace Nobatgir.Controllers
{
    public class HomeController : Controller
    {
        private readonly Repository _repository;

        public HomeController(Repository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var viewname = this._repository.GetSiteKindSetting(Settings.ViewName);

            ViewBag.Title = this._repository.GetSiteSetting(Settings.SiteTitle);
            ViewBag.ViewName = viewname;

            return View("/Views/" + viewname + "/index.cshtml");
        }

        public IActionResult AddTurn(string time, DateTime turndate)
        {
            var viewname = this._repository.GetSiteKindSetting(Settings.ViewName);

            ViewBag.Title = this._repository.GetSiteSetting(Settings.SiteTitle);
            ViewBag.ViewName = viewname;

            _repository.AddTurn(turndate, time);

            return View("/Views/" + viewname + "/AddTurn.cshtml");
        }
    }
}