using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Nobatgir.Model;

namespace Nobatgir.Model
{
    public class AdminMenu : BaseClass
    {
        [Display(Name = "کنترلر")]
        public string Controller { get; set; }
    }
}
