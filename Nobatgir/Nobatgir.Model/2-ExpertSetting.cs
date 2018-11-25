using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class ExpertSetting:BaseSetting
    {
        [Display(Name = "بخش")]
        public Expert Expert { get; set; }

        public int ExpertID { get; set; }
    }
}
