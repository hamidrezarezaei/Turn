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

        public FieldTypes FieldType { get; set; }

        public string Value { get; set; }

        public int SourceTypeID { get; set; }

        public SourceType SourceType { get; set; }

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
            var r = ((int[]) Enum.GetValues(typeof(FieldTypes)))
                .Select(x => new FieldType {ID = x, Name = Enum.GetName(typeof(FieldTypes), x)});

            return r.ToList();
        }
    }

    public enum FieldTypes
    {
        TextBox = 1, CheckBox = 2, ComboBox = 3, TextArea = 4, RadioButton = 5
    }
}

