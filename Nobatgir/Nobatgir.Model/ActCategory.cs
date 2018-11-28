using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class ActCategory : BaseClass
    {
        public IEnumerable<Act> Acts { get; set; }
    }
}
