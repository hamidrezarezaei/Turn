using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text;
using Nobatgir.Lib;

namespace Nobatgir.Model
{
    public class BaseClass
    {
        public BaseClass()
        {
            this.IsActive = true;
            this.IsDeleted = false;
            this.UpdateDateTime = DateTime.Now;
            this.OrderIndex = 1;
        }

        [Display(Name = "شناسه")]
        public int ID { get; set; }

        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "فعال")]
        public bool IsActive { get; set; }

        [Display(Name = "ترتیب نمایش")]
        public int OrderIndex { get; set; }

        [Display(Name = "آخرین تغییر دهنده")]
        public int UserID { get; set; }

        [Display(Name = "زمان آخرین تغییر")]
        public DateTime UpdateDateTime { get; set; }

        [Display(Name = "حذف شده")]
        public bool IsDeleted { get; set; }

        [NotMapped]
        public string PersianUpdateDate => persianDateTime.PersianDateStringFormat(this.UpdateDateTime);

        [NotMapped]
        public string PersianUpdateTime => persianDateTime.PersianTimeStringFormat(this.UpdateDateTime);
    }
}
