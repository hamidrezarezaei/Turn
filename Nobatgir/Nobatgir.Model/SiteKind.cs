using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class SiteKind : BaseClass
    {
        public IEnumerable<Site> Sites { get; set; }

        public IEnumerable<SiteKindDictionary> SiteKindDictionaries { get; set; }
    }

    public enum SiteKinds
    {
        SuperAdmin = 1,
        Clinic = 2,
        Doctor = 3,
        BarberShop = 4,
        Barber = 5
    }
}
