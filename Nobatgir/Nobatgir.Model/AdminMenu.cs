using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class AdminMenu : BaseClass
    {
        public int SiteKindID { get; set; }

        [Display(Name = "نام کنترلر")]
        public string ControllerName { get; set; }

        [Display(Name = "نام اکشن")]
        public string ActionName { get; set; }

        public int LevelID { get; set; }

        public SiteKind SiteKind { get; set; }
    }
}
