using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nobatgir.Model
{
    public class BaseTimeTemplate : BaseClass
    {
        [Display(Name = "روز هفته")]
        public int WeekDay { get; set; }

        [Display(Name = "زمان ها")]
        public string Times { get; set; }

        [Display(Name = "از چند روز قبل")]
        public int ActiveDayCount { get; set; }

        [Display(Name = "شروع از ساعت")]
        public string ActiveTime { get; set; }

        [Display(Name = "تا چند روز قبل")]
        public int DeactiveDayCount { get; set; }

        [Display(Name = "تا ساعت")]
        public string DeactiveTime { get; set; }

        [NotMapped]
        public string WeekDayName => Enum.GetName(typeof(DayOfWeekPersians), this.WeekDay);
    }
}