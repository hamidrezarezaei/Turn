using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class Role : IdentityRole<int>
    {
        public int SiteID { get; set; }

        public Site Site { get; set; }
    }
}
