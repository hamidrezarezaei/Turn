using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class SiteKindDictionary : BaseDictionary
    {
        public int SiteKindID { get; set; }

        public SiteKind SiteKind { get; set; }
    }
}
