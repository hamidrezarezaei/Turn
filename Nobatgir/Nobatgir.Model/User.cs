using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class User : IdentityUser<int>
    {
        public int SiteID { get; set; }

        // نباید این وجود داشته باشد به دلیل ساخت جدول اضافی
        //public Site Site { get; set; }
    }
}
