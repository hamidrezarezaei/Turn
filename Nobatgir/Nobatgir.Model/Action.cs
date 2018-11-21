using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class Action : BaseClass
    {
        public int ActionCategoryID { get; set; }
        public ActionCategory ActionCategory { get; set; }
    }
}
