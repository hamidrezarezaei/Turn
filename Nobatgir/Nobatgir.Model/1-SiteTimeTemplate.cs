using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class SiteTimeTemplate : BaseTimeTemplate
    {
        public int SiteID { get; set; }

        public Site Site { get; set; }
    }
}
