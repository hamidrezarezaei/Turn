using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class Setting 
    {
        public int ID { get; set; }

        [Display(Name = "کلید")]
        public string Key { get; set; }

        [Display(Name = "مقدار")]
        public string Value { get; set; }

        [Display(Name = "سایت")]
        public Expert Expert { get; set; }
    }
}
