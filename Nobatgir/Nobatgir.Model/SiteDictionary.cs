using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class SiteDictionary : BaseDictionary
    {
        public int SiteID { get; set; }

        public Site Site { get; set; }
    }
}
