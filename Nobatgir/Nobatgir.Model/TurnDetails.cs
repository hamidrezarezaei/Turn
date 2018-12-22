using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Nobatgir.Lib;

namespace Nobatgir.Model
{
    public class TurnDetails
    {
        public int ID { get; set; }

        public Guid TurnID { get; set; }

        public Turn Turn { get; set; }

        public int ExpertFieldID { get; set; }

        public ExpertField ExpertField { get; set; }

        public string Value { get; set; }

        [NotMapped]
        public string ValueText
        {
            get
            {
                if (this.ExpertField.FieldType == FieldTypes.ComboBox)
                {
                    var r = this.ExpertField.SourceType.SourceValues.FirstOrDefault(x => x.ID.ToString() == this.Value)?.Title;
                    return r;
                }

                if (this.ExpertField.FieldType == FieldTypes.CheckBox)
                {
                    return this.Value == "true" ? "بله" : "خیر";
                }

                return this.Value;
            }
        }
    }
}
