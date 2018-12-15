using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Nobatgir.Model
{
    public class ExpertField : BaseClass
    {
        public int ExpertID { get; set; }

        public Expert Expert { get; set; }

        [Display(Name = "نوع پارامتر")]
        public FieldTypes FieldType { get; set; }

        [Display(Name = "مقدار اولیه")]
        public string Value { get; set; }

        [Display(Name = "برچسب")]
        public string Placeholder { get; set; }

        [Display(Name = "نوع فهرست")]
        public int? SourceTypeID { get; set; }

        public SourceType SourceType { get; set; }

        [Display(Name = "متن HTML")]
        public string FieldText { get; set; }

        [Display(Name = "کلاس css")]
        public string CssClass { get; set; }

        [NotMapped]
        public string FieldTypeName => Enum.GetName(typeof(FieldTypes), this.FieldType);

        [NotMapped]
        public string SourceTypeTitle => this.SourceType?.Title;
    }

    public class FieldType
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static List<FieldType> GetList()
        {
            var r = ((int[])Enum.GetValues(typeof(FieldTypes)))
                .Select(x => new FieldType { ID = x, Name = Enum.GetName(typeof(FieldTypes), x) });

            return r.ToList();
        }
    }

    public enum FieldTypes
    {
        TextBox = 1, CheckBox = 2, ComboBox = 3, TextArea = 4, RadioButton = 5, HTML = 6
    }
}

