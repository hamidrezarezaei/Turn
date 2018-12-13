using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nobatgir.Model;

namespace Nobatgir.ViewModel
{
    public class TimeTemplateViewModel
    {
        //public DayOfWeekPersians DayOfWeekPersian { get; set; }

        //public PersianMonths PersianMonth { get; set; }

        //public int Day { get; set; }

        public List<Model.Turn> Turns { get; set; }

        public DateTime Day { get; set; }

        public string FullDay => Nobatgir.Lib.persianDateTime.PersianDateStringFormat(this.Day);// this.DayOfWeekPersian.ToString().Replace("_", " ") + " " + this.Day + " " + this.PersianMonth;
    }
}
