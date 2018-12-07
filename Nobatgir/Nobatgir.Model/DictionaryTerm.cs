using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class DictionaryTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public string Term { get; set; }
    }

    public enum Terms
    {
        Expert = 1,
        Experts = 2,
    }
}
