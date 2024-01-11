using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Complete the method which accepts an array of integers, and returns one of the following:

        "yes, ascending" - if the numbers in the array are sorted in an ascending order
        "yes, descending" - if the numbers in the array are sorted in a descending order
        "no" - otherwise
    */
    internal class IsSortedAndHows
    {
        public static string IsSortedAndHow(int[] array)
        {
            bool ascending = array.SequenceEqual(array.OrderBy(x => x));
            bool descending = array.SequenceEqual(array.OrderByDescending(x => x));

            if (ascending)
            {
                return "yes, ascending";
            }
            else if (descending)
            {
                return "yes, descending";
            }
            else
            {
                return "no";
            }
        }
    }
}
