using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Given a non-empty array of integers, return the result of multiplying the values together in order. */
    internal class Grows
    {
        public static int Grow(int[] x)
        {
            int result = 1;
            foreach (int num in x)
            {
                result *= num;
            }
            return result;
        }
    }

}
