using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class ExpertCategory : BaseClass
    {
        public Category Category { get; set; }

        public int CategoryID { get; set; }

        public Expert Expert { get; set; }

        public int ExpertID { get; set; }
    }
}
