using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class SiteTimeTemplate : BaseTimeTemplate
    {
        [Display(Name = "سایت")]
        public Site Site { get; set; }

        public int SiteID { get; set; }
    }
}
