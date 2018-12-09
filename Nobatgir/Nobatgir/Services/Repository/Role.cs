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
        public IEnumerable<Role> GetRoleList()
        {
            return this._rolemanager.Roles.Where(x => x.SiteID == this.SiteID);
        }

        public Role GetRole(int ID)
        {
            return this._rolemanager.Roles.FirstOrDefault(x => x.Id == ID);
        }

        public bool CreateRole(string roleName, string title)
        {
            var r = this._rolemanager.CreateAsync(new Role
            {
                Name = roleName,
                Title = title,
                SiteID = this.SiteID,
                UserID = this.UserID
            }).Result;

            return r.Succeeded;
        }

    }
}
