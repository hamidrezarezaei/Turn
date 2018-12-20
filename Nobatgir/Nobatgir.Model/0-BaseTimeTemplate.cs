using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Nobatgir.Model
{
    public class BaseTimeTemplate : BaseClass
    {
        [Display(Name = "روز هفته")]
        public DayOfWeek WeekDay { get; set; }

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

        [NotMapped]
        public TimeSpan ActiveTimeSpan => TimeSpan.Parse(this.ActiveTime);

        [NotMapped]
        public TimeSpan DeactiveTimeSpan => TimeSpan.Parse(this.DeactiveTime);

        [NotMapped]
        public List<string> TimesList => this.Times.Split(';').ToList();

        [NotMapped]
        public List<TimeSpan> TimesSpanList
        {
            get
            {
                if (!TimeSpan.TryParse(TimesList[0], out _))
                {
                    return null;
                }

                return TimesList.Select(TimeSpan.Parse).ToList();
            }
        }
    }
}