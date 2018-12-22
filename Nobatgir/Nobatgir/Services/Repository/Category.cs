using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nobatgir.Data;
using Nobatgir.Model;
using Nobatgir.ViewModel;

namespace Nobatgir.Services
{
    public partial class Repository
    {
        public PagedResult<Model.Category> GetCategories(int pageNumber, string searchString = "")
        {
            var data = GetListByParentWithPaging<Category, int>(x => x.SiteID, SiteID, pageNumber, searchString);
            return data;
        }

        public Category AddDefaultCategory(int siteid, string cattitle, string catname)
        {
            var c = new Category
            {
                IsActive = true,
                IsDeleted = false,
                Name = catname + "Default",
                Title = cattitle + " پیش فرض",
                SiteID = siteid,
            };

            return this.AddRow(c);
        }
    }
}
