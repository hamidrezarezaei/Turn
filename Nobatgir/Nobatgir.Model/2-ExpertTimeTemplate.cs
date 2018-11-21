using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class ExpertTimeTemplate : BaseTimeTemplate
    {
        public int ExpertID { get; set; }

        public Expert Expert { get; set; }

    }
}
