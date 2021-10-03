using System;
using System.Globalization;

namespace Utility.Converter
{
    public static class DateConvertor
    {
        public static string PersianDate(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value).ToString("yyyy") + "/" + pc.GetMonth(value).ToString("MM") + "/" + pc.GetDayOfMonth(value).ToString("dd");
        }
    }
}