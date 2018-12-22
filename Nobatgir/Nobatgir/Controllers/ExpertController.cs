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
            var viewname = this._repository.GetSetting(Settings.ViewName);

            ViewBag.Title = this._repository.GetSetting(Settings.SiteTitle);
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
            // حذف موارد قبلی
            _repository.DeleteTurnDetails(f.Turn.ID);

            // اضافه کردن جزییات
            if (f.ExpertFields != null)
                _repository.AddTurnDetails(f.Turn.ID, f.ExpertFields);

            // دریافت فرمول و محاسبه
            {
                var formula = _repository.GetSetting(Settings.Formula);

                formula = Regex.Replace(formula, "\\[([-a-z0-9]+)\\]",
                    m => _repository.GetTurnDetailsValue(f.Turn.ID, m.Groups[1].Value.ToLower()), RegexOptions.IgnoreCase);

                string func = @"function Func() {" + formula + "}";

                var GetResult = new Jint.Engine()
                    .Execute(func)
                    .GetValue("Func");

                var price = (long)(double)GetResult.Invoke().ToObject();

                f.Turn.Price = price;
            }

            _repository.UpdateTurnPrice(f.Turn.ID, f.Turn.Price);

            return View(this.GetViewName("VerifyTurn"), f.Turn);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Verified(Guid TurnID)
        {
            var t = _repository.GetTurn(TurnID);

            var c = new CompletedViewModel { Turn = t };

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