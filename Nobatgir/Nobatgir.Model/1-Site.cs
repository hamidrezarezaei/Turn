using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class Site : BaseClass
    {
        [Display(Name = "دامنه")]
        public string Domain { get; set; }

        public IEnumerable<SiteSetting> SiteSettings { get; set; }

        public IEnumerable<SiteTimeTemplate> SiteTimeTemplates { get; set; }
    }
}
