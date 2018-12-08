using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nobatgir.Data;
using Nobatgir.Model;
using Nobatgir.ViewModel;
using WebApplication1.Models.AccountViewModels;

namespace Nobatgir.Services
{
    public partial class Repository
    {
        public User CreateUser(RegisterViewModel model)
        {
            //var user = new Nobatgir.Model.User { UserName = model.Email, Email = model.Email, SiteID = this.SiteId };
            var user = new Nobatgir.Model.User { UserName = model.Email, Email = model.Email};

            return user;
        }

        public IEnumerable<User> GetUserList()
        {
            return this._usermanager.Users.Where(x=>x.SiteID == this.SiteId);
        }

        public User GetUser(int ID)
        {
            return this._usermanager.Users.FirstOrDefault(x => x.Id == ID);
        }
    }
}
