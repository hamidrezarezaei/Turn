using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class Act : BaseClass
    {
        [Display(Name = "نام کنترلر")]
        public string ControllerName { get; set; }

        [Display(Name = "نام اکشن")]
        public string ActName { get; set; }

        public int ActCategoryID { get; set; }

        public ActCategory ActCategory { get; set; }
    }
}
