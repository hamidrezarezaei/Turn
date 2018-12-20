using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class BaseSetting : BaseClass
    {
        [Display(Name = "مقدار")]
        public string Value { get; set; }
    }
}
