using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class Turn
    {
        public int ID { get; set; }

        public DateTime RegDate { get; set; }

        public string Time { get; set; }
    }
}
