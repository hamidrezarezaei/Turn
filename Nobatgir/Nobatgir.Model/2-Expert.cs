using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class Expert : BaseClass
    {
        [Display(Name = "بخش")]
        public Category Category { get; set; }

        public int CategoryID { get; set; }

        public IEnumerable<ExpertSetting> ExpertSettings { get; set; }

        public IEnumerable<ExpertTimeTemplate> ExpertTimeTemplates { get; set; }
    }
}
