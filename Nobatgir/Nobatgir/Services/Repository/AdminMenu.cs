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
        public IEnumerable<AdminMenu> GetAdminMenuList()
        {
            return GetListActive<AdminMenu>().Where(x => x.LevelID == userLevelID && x.SiteKindID == this.SiteKindID);
        }
    }
}
