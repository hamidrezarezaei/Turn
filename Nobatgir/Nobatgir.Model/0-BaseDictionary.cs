using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class BaseDictionary 
    {
        public int ID { get; set; }

        public int DictionaryTermID { get; set; }

        [Display(Name = "لغت")]
        public DictionaryTerm DictionaryTerm  { get; set; }

        [Display(Name = "مقدار")]
        public string Value { get; set; }
    }
}
