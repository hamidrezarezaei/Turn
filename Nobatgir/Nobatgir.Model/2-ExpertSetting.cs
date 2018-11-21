using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class ExpertSetting
    {
        public int ID { get; set; }

        [Display(Name = "کلید")]
        public string Key { get; set; }

        [Display(Name = "مقدار")]
        public string Value { get; set; }

        [Display(Name = "بخش")]
        public Expert Expert { get; set; }
        public int ExpertID { get; set; }
    }
}
