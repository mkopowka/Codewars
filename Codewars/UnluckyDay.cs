using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*Friday 13th or Black Friday is considered as unlucky day. Calculate how many unlucky days are in the given year.

    Find the number of Friday 13th in the given year.
    */
    internal class UnluckyDay
    {
        public static int UnluckyDays(int year)
        {
            DateTime startDate = new DateTime(year, 1, 1);
            DateTime endDate = new DateTime(year, 12, 31);
            int unluckyCount = 0;
            DateTime currentDate = startDate;
            while (currentDate <= endDate)
            {
                if (currentDate.DayOfWeek == DayOfWeek.Friday && currentDate.Day == 13)
                {
                    unluckyCount++;
                }
                currentDate = currentDate.AddDays(1);
            }

            return unluckyCount;
        }
    }
}
