using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * In this kata, we will make a function to test whether a period is late.

    Our function will take three parameters:

    last - The Date object with the date of the last period

    today - The Date object with the date of the check

    cycleLength - Integer representing the length of the cycle in days

    Return true if the number of days passed from last to today is greater than cycleLength. Otherwise, return false.
    */
    internal class PeriodIsLates
    {
        public static bool PeriodIsLate(DateTime last, DateTime today, int cycleLength)
        {
            int daysPassed = (int)(today - last).TotalDays;

            bool isLate = daysPassed > cycleLength;

            return isLate;
        }
    }
}
