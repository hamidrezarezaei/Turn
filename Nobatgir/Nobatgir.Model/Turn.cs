using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class Turn
    {
        public Guid ID { get; set; }

        public int ExpertID { get; set; }

        public DateTime TurnDate { get; set; }

        public string Time { get; set; }

        public TurnStatuses Status { get; set; }

        public DateTime RegDate { get; set; }

        public Expert Expert { get; set; }
    }

    public enum TurnStatuses
    {
        Reserve, Completed, Deleted
    }
}
