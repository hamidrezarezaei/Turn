using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Nobatgir.Model;
using Nobatgir.Services;
using Nobatgir.ViewModel;

namespace Nobatgir.Controllers
{
    public class ExpertController : Controller
    {
        private readonly Repository _repository;

        public ExpertController(Repository repository)
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

        private IActionResult GotoHome()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Index()
        {
            return View(this.GetViewName("category"));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddTurn(string time, DateTime turndate)
        {
            //کنترل اینکه آیا این زمان برای دکتر قابل گرفته شدن است

            // کنترل تداخل زمان
            var turn = _repository.CheckTurnConflict(time, turndate);

            Guid turnid;

            // اگر نوبتی برای این زمان وجود نداشت
            if (turn == null)
            {
                var t = _repository.AddTurn(turndate, time);

                HttpContext.Session.SetString("TurnID", t.ID.ToString());

                turnid = t.ID;
            }
            else
            {
                // اگر نوبت توسط شخص جاری گرفته شده است
                if (turn.ID == _repository.SessionTurnID)
                    turnid = turn.ID;
                else
                {
                    //errror go to home
                    return this.GotoHome();
                }
            }

            return View(this.GetViewName("AddTurn"), turnid);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult VerifyTurn(TurnFieldsViewModel f)
        {
            _repository.DeleteTurnDetails(f.Turn.ID);
            _repository.AddTurnDetails(f.Turn.ID, f.ExpertFields);

            var formula = _repository.GetExpertSetting(Settings.Formula);

            formula = Regex.Replace(formula, "\\[(\\w+)\\]", m =>
            {
                return _repository.GetTurnDetailsValue(f.Turn.ID, m.Groups[1].Value.ToLower());
            });

            string func = @"function Func() {" + formula + "}";

            var GetResult = new Jint.Engine()
                .Execute(func)
                .GetValue("Func");

            var price = (long)(double)GetResult.Invoke().ToObject();

            f.Turn.Price = price;

            return View(this.GetViewName("VerifyTurn"), f.Turn);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Verified(Guid TurnID)
        {
            var t = _repository.GetTurn(TurnID);

            var c = new CompletedViewModel {Turn = t};

            _repository.CompleteTurn(t.ID);

            _repository.SessionTurnID = null;

            return View(this.GetViewName("Completed"), c);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CancelTurn(Guid TurnID)
        {
            _repository.CancelTurn(TurnID);
            _repository.SessionTurnID = null;

            return this.GotoHome();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult VerifyBack(Guid TurnID)
        {
            return View(this.GetViewName("AddTurn"), TurnID);
        }
    }
}