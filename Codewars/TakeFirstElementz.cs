using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Write a function to get the first element(s) of a sequence. Passing a parameter n (default=1) will return the first n element(s) of the sequence.

        If n == 0 return an empty sequence []
    */
    internal class TakeFirstElementz
    {
        public static object[] TakeFirstElements(object[] array, int n = 1)
        {
            if (n == 0)
            {
                return new object[] { };
            }

            return array.Take(n).ToArray();
        }
    }
}
