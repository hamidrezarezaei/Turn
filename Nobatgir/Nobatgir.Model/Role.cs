using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Nobatgir.Lib;

namespace Nobatgir.Model
{
    public class Role : IdentityRole<int>
    {
        public Role()
        {
            this.IsActive = true;
            this.IsDeleted = false;
            this.UpdateDateTime = DateTime.Now;
            this.OrderIndex = 1;
        }

        public int SiteID { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "فعال")]
        public bool IsActive { get; set; }

        [Display(Name = "ترتیب نمایش")]
        public int OrderIndex { get; set; }

        [Display(Name = "حذف شده")]
        public bool IsDeleted { get; set; }

        [Display(Name = "زمان آخرین تغییر")]
        public DateTime UpdateDateTime { get; set; }

        [Display(Name = "آخرین تغییر دهنده")]
        public int UserID { get; set; }

        [NotMapped]
        public string PersianUpdateDate => persianDateTime.PersianDateStringFormat(this.UpdateDateTime);

        [NotMapped]
        public string PersianUpdateTime => persianDateTime.PersianTimeStringFormat(this.UpdateDateTime);

        // نباید این وجود داشته باشد به دلیل ساخت جدول اضافی
        //   public Site Site { get; set; }
    }
}
