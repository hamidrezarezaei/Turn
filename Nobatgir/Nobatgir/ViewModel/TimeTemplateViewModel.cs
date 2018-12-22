using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nobatgir.Model;

namespace Nobatgir.ViewModel
{
    public class TimeTemplateViewModel
    {
        public List<Model.Turn> Turns { get; set; }

        public DateTime Day { get; set; }

        //public string FullDay => ;// this.DayOfWeekPersian.ToString().Replace("_", " ") + " " + this.Day + " " + this.PersianMonth;
    }
}
