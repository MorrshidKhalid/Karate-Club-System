using System;
using System.Windows.Forms;

namespace KCDesktop.helper_lib
{
    public class Date
    {

        public static bool IsLeap(short y) => (y % 400 == 0) || (y % 4 == 0 && y % 100 != 0);

        public static short DaysCountInYear(short y) => (short)(IsLeap(y) ? 366 : 365);

        public static short DaysInMonth(DateTimePicker d)
        {
            if (d.Value.Date.Month == 2)
                if (IsLeap((short)d.Value.Date.Year))
                    return (short)((DaysCountInYear((short)d.Value.Date.Year) / 12) - 1);
                else return (short)((DaysCountInYear((short)d.Value.Date.Year) / 12) - 2);

            else if 
                ((d.Value.Date.Month % 2 == 1 && d.Value.Date.Month <= 7) ||
                (d.Value.Date.Month % 2 == 0 && d.Value.Date.Month >= 8))
                return 31;

            else return 30;
        }

        public static bool IsLastDay(DateTimePicker d) => DaysInMonth(d) == d.Value.Date.Day;

        public static bool IsLastMonth(DateTimePicker d) => d.Value.Date.Month == 12;

        public static int DifferenceInDays(DateTimePicker d1, DateTimePicker d2)
        {
            if (d1.Value.Date == d2.Value.Date)
                return 1;

            var days = d2.Value.Subtract(d1.Value.Date);

            return days.Days + 1;
        }
    }
}
