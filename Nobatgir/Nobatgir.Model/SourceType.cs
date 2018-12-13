using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class SourceType : BaseClass
    {
        public IEnumerable<SourceValue> SourceValues { get; set; }
    }
}
