using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class Expert : BaseClass
    {
        [Display(Name = "سایت")]
        public Site Site { get; set; }

        public IEnumerable<ExpertSetting> ExpertSettings { get; set; }

        public IEnumerable<ExpertTimeTemplate> ExpertTimeTemplates { get; set; }
    }
}
