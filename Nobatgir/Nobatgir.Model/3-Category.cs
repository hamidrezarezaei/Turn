using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class Category : BaseClass
    {
        public IEnumerable<CategorySetting> CategorySettings { get; set; }

        public IEnumerable<CategoryTimeTemplate> CategoryTimeTemplates { get; set; }
    }
}
