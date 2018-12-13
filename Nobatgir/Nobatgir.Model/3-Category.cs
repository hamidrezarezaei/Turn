using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class Category : BaseClass
    {
        [Display(Name = "سایت")]
        public Site Site { get; set; }

        public int SiteID { get; set; }

        public IEnumerable<CategorySetting> CategorySettings { get; set; }

        public IEnumerable<Expert> Experts { get; set; }
    }
}
