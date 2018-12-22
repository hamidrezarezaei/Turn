using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nobatgir.Model;

namespace Nobatgir.Areas.Admin.ViewModel
{
    public class CalendarShowDayViewModel
    {
        public string Date { get; set; }

        public IEnumerable<Turn> Turns { get; set; }
    }
}
