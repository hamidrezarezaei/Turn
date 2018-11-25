using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class ExpertTimeTemplate : BaseTimeTemplate
    {
        public Expert Expert { get; set; }

        public int ExpertID { get; set; }

    }
}
