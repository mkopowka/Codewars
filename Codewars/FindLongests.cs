using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Find the number with the most digits.

        If two numbers in the argument array have the same number of digits, return the first one in the array.
    */
    internal class FindLongests
    {
        public static int FindLongest(int[] number)
        {
            return number.OrderByDescending(n => n.ToString().Length).First();
        }
    }
}
