using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class CategoryTimeTemplate : BaseTimeTemplate
    {
        public Category Category { get; set; }

        public int CategoryID { get; set; }
    }
}
