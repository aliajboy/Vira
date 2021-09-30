using System;
using System.Globalization;

namespace Utility.Converter
{
    public static class DateConvertor
    {
        public static string PersianDate(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value).ToString() + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value).ToString("00");
        }
    }
}