using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nobatgir.Areas.Admin.ViewModel;
using Nobatgir.Model;
using Nobatgir.Services;

namespace Nobatgir.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : BaseController
    {
        #region Constructor
        public UserController(Repository repository) : base(repository)
        {
            //this.type = typeof(User);
        }
        #endregion

        public ActionResult Index(int pageNumber, string searchString)
        {
            var userlist = this.repository.GetUserList().Select(x => new UserViewModel
            {
                ID = x.Id,
                IsActive = true,
                IsDeleted = false,
                Name = x.UserName,
                OrderIndex = 1,
                Title = x.UserName,
                User = x
            });

            var data = this.repository.GetPagedResult(userlist.AsQueryable(), pageNumber, searchString);
            ViewBag.SearchString = searchString;

            return View(data);
        }

        public override IActionResult Details(int? id, int pageNumber, string searchString, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.repository.GetUser(id.Value);

            if (row == null)
                return NotFound();

            var uvm = new UserViewModel
            {
                ID = row.Id,
                IsActive = true,
                IsDeleted = false,
                Name = row.UserName,
                OrderIndex = 1,
                Title = row.UserName,
                User = row
            };

            return View(new DetailsViewModel<BaseClass> { Row = uvm, ActionType = ActionTypes.Details });
        }

        public override IActionResult Edit(int? id, string ReturnURL)
        {
            if (id == null)
                return NotFound();

            var row = this.repository.GetUser(id.Value);

            if (row == null)
                return NotFound();

            ViewBag.ReturnURL = ReturnURL;

            var uvm = new UserViewModel
            {
                ID = row.Id,
                IsActive = true,
                IsDeleted = false,
                Name = row.UserName,
                OrderIndex = 1,
                Title = row.UserName,
                User = row
            };

            return View(new DetailsViewModel<BaseClass> { Row = uvm, ActionType = ActionTypes.Edit });
        }


    }
}