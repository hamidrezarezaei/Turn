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
        SinglularExpert = 1,
        PluralExpert = 2,
        AddNewExpert = 3,
        EditExpert = 4,
        DeleteExpert = 5,
        SinglularCategory = 6,
        PluralCategory = 7,
        AddNewCategory = 8,
        EditCategory = 9,
        DeleteCategory = 10
    }
}
