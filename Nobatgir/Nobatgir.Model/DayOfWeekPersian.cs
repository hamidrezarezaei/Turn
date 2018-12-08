using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Nobatgir.Model
{
    /// <summary>
    /// روزهای هفته شمسی
    /// </summary>
    enum DayOfWeekPersians
    {
        یکشنبه = 0,
        دوشنبه = 1,
        سه‌شنبه = 2,
        چهارشنبه = 3,
        پنجشنبه = 4,
        جمعه = 5,
        شنبه = 6,
    }

    /// <summary>
    /// کلاس روزهای هفته شمسی برای استفاده در combo
    /// </summary>
    public class DayOfWeekPersian
    {
        public int ID { get; set; }
        public string WeekDay { get; set; }

        /// <summary>
        /// فهرست روزهای هفته با ترتیب
        /// </summary>
        /// <returns></returns>
        public static List<DayOfWeekPersian> GetList()
        {
            var r = ((int[])Enum.GetValues(typeof(DayOfWeekPersians)))
                .Select(x => new DayOfWeekPersian { ID = x, WeekDay = Enum.GetName(typeof(DayOfWeekPersians), x) })
                .OrderBy(x => (x.ID + 1) % 7);

            return r.ToList();
        }
    }
}
