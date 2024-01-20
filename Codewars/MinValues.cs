using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Given a list of digits, return the smallest number that could be formed from these digits, using the digits only once (ignore duplicates). */
    internal class MinValues
    {
        public static long MinValue(int[] a)
        {
            int[] uniqueDigits = a.Distinct().OrderBy(d => d).ToArray();
            string minValueStr = string.Join("", uniqueDigits);
            int minValue = int.Parse(minValueStr);

            return minValue;
        }
    }
}
