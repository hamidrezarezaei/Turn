using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class ActionCategory : BaseClass
    {
        public IEnumerable<Action> Actions { get; set; }
    }
}
