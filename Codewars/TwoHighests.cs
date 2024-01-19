using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * In this kata, your job is to return the two distinct highest values in a list. If there're less than 2 unique values, return as many of them, as possible.

The result should also be ordered from highest to lowest.
    */
    internal class TwoHighests
    {
        public static int[] TwoHighest(int[] arr)
        {
            int[] uniqueSortedNumbers = arr.Distinct().OrderByDescending(x => x).ToArray();

            return uniqueSortedNumbers.Take(Math.Min(2, uniqueSortedNumbers.Length)).ToArray();
        }
    }
}
