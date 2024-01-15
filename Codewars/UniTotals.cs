using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* You'll be given a string, and have to return the sum of all characters as an int. The function should be able to handle all printable ASCII characters. */
    internal class UniTotals
    {
        public static int UniTotal(string str)
        {
            int sum = 0;

            foreach (char character in str)
            {
                sum += (int)character;
            }

            return sum;
        }
    }
}
