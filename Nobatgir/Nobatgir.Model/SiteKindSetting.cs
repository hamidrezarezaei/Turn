using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class SiteKindSetting : BaseSetting
    {
        public int SiteKindID { get; set; }

        [Display(Name = "نوع سایت")]
        public SiteKind SiteKind { get; set; }
    }
}
