using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nobatgir.Model;

namespace Nobatgir.Areas.Admin.ViewModel
{
    public class RoleViewModel : BaseClass
    {
        public RoleViewModel()
        {
        }

        public RoleViewModel(Role role)
        {
            this.Role = role;

            this.ID = role.Id;
            this.IsActive = role.IsActive;
            this.IsDeleted = role.IsDeleted;
            this.Name = role.Name;
            this.OrderIndex = role.OrderIndex;
            this.Title = role.Title;
            this.UpdateDateTime = role.UpdateDateTime;
            this.UserID = role.UserID;
        }

        public Role Role { get; set; }

        //public int SiteID { get; set; }
    }
}
