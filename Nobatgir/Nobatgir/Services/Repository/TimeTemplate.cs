using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nobatgir.Data;
using Nobatgir.Model;
using Nobatgir.ViewModel;

namespace Nobatgir.Services
{
    public partial class Repository
    {
        public List<TimeTemplateViewModel> GetTimeTemplates()
        {
            var r = new List<TimeTemplateViewModel>();

            // فهرست قالب زمان های expert
            var lst = this.GetListActiveByParent<ExpertTimeTemplate, int>(x => x.ExpertID, this.ExpertID).ToList();

            if (!lst.Any())
                return null;

            var now = DateTime.Now;
            var currenttime = now.TimeOfDay;

            // حداکثر روزهای قابل رزرو
            var max = lst.Max(x => x.ActiveDayCount) + 1;

            var lstturns = this.GetTurnsExpert(this.ExpertID, now.AddDays(-1), now.AddDays(max)).ToList();

            for (int i = 0; i <= max; i++)
            {
                var d = lst.FirstOrDefault(x => x.WeekDay == now.AddDays(i).DayOfWeek);
                if (d != null)
                {
                    var startpoint = new DateTime(now.Year, now.Month, now.Day).AddDays(i);

                    var startperiod = startpoint.AddDays(-d.ActiveDayCount).AddHours(d.ActiveTimeSpan.Hours).AddMinutes(d.ActiveTimeSpan.Minutes);

                    var endperiod = startpoint.AddDays(-d.DeactiveDayCount).AddHours(d.DeactiveTimeSpan.Hours).AddMinutes(d.DeactiveTimeSpan.Minutes);

                    if (now.CompareTo(startperiod) >= 0 && now.CompareTo(endperiod) <= 0)
                    {
                        var times = d.TimesList;

                        // برای امروز
                        if (i == 0 && d.TimesSpanList != null)
                        {
                            times = d.TimesSpanList.Where(x => x.CompareTo(currenttime) > 0).Select(x => x.ToString("hh\\:mm")).ToList();
                        }

                        var turntimes = times.Select(x => new Turn { Time = x }).ToList();

                        foreach (var turn in turntimes)
                        {
                            var f = lstturns.FirstOrDefault(x => x.TurnDate == startpoint && x.Time == turn.Time && x.Status == TurnStatuses.Completed);
                            if (f != null)
                            {
                                turn.Status = TurnStatuses.Completed;
                                continue;
                            }

                            f = lstturns.FirstOrDefault(x => x.TurnDate == startpoint && x.Time == turn.Time && x.Status == TurnStatuses.Reserve);
                            if (f != null)
                            {
                                turn.Status = TurnStatuses.Reserve;
                                continue;
                            }

                            turn.Status = TurnStatuses.Free;
                        }

                        r.Add(new TimeTemplateViewModel
                        {
                            Day = startpoint,
                            Turns = turntimes
                        });
                    }
                }
            }

            return r;
        }

        public IEnumerable<string> GetTimeTemplatesTimes(DayOfWeek week)
        {
            var lst = this.GetListActiveByParent<ExpertTimeTemplate, int>(x => x.ExpertID, this.ExpertID)
                .FirstOrDefault(x => x.WeekDay == week)?.TimesList;

            return lst;
        }
    }
}
