using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16_Essential_
{
    internal class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public static int operator -(Date a, Date b)
        {
            return (int)(new DateTime(a.Year, a.Month, a.Day) - new DateTime(b.Year, b.Month, b.Day)).TotalDays;
        }
        public static Date operator +(Date date, int days)
        {
            TimeSpan ts = new TimeSpan(days, 0 , 0, 0);
            DateTime dateTime = new DateTime(date.Year, date.Month, date.Day);
            dateTime = dateTime.Add(ts);
            return new Date() { Day = dateTime.Day , Month = dateTime.Month, Year = dateTime.Year };
        }

        public override string ToString()
        {
            return Day + ", " + Month + ", " + Year;
        }
    }
}
