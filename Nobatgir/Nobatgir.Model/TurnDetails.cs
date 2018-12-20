using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    }
}
