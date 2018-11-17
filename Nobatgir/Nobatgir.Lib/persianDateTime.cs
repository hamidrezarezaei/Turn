﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Nobatgir.Lib
{
    public class persianDateTime
    {
        public static string PersianDateStringFormat(DateTime dateTime)
        {
            try
            {
                PersianCalendar pc = new PersianCalendar();
                int y = pc.GetYear(dateTime);
                int m = pc.GetMonth(dateTime);
                int d = pc.GetDayOfMonth(dateTime);
                var dow = pc.GetDayOfWeek(dateTime);

                string res = "";
                switch (dow)
                {
                    case DayOfWeek.Friday:
                        res = "جمعه";
                        break;
                    case DayOfWeek.Monday:
                        res = "دوشنبه";
                        break;
                    case DayOfWeek.Saturday:
                        res = "شنبه";
                        break;
                    case DayOfWeek.Sunday:
                        res = "یکشنبه";
                        break;
                    case DayOfWeek.Thursday:
                        res = "پنجشنبه";
                        break;
                    case DayOfWeek.Tuesday:
                        res = "سه شنبه";
                        break;
                    case DayOfWeek.Wednesday:
                        res = "چهارشنبه";
                        break;
                }
                res += " " + d.ToString() + " ";

                switch (m)
                {
                    case 1:
                        res += "فروردین";
                        break;
                    case 2:
                        res += "اردیبهشت";
                        break;
                    case 3:
                        res += "خرداد";
                        break;
                    case 4:
                        res += "تیر";
                        break;
                    case 5:
                        res += "مرداد";
                        break;
                    case 6:
                        res += "شهریور";
                        break;
                    case 7:
                        res += "مهر";
                        break;
                    case 8:
                        res += "آبان";
                        break;
                    case 9:
                        res += "آذر";
                        break;
                    case 10:
                        res += "دی";
                        break;
                    case 11:
                        res += "بهمن";
                        break;
                    case 12:
                        res += "اسفند";
                        break;
                }
                res += " " + y.ToString();
                return res;
            }
            catch
            {
                return "";
            }
        }

        public static string PersianTimeStringFormat(DateTime dateTime)
        {
            try
            {
                PersianCalendar pc = new PersianCalendar();
                int h = pc.GetHour(dateTime);
                int m = pc.GetMinute(dateTime);

                string res = "ساعت";
                res += " " + h.ToString().PadLeft(2, '0') + ":" + m.ToString().PadLeft(2, '0');
                return res;
            }
            catch
            {
                return "";
            }
        }
    }
}
