using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Create a function that returns the average of an array of numbers ("scores"), rounded to the nearest whole number. You are not allowed to use any loops (including for, for/in, while, and do/while loops).

The array will never be empty.
    */
    internal class Averages
    {
        public static int Average(int[] scores)
        {
            return (int)Math.Round(scores.Average());
        }
    }
}
