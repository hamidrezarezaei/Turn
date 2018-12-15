using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class SourceValue : BaseClass
    {
        public int SourceTypeID { get; set; }

        public SourceType SourceType { get; set; }

        public string Value { get; set; }
    }
}
