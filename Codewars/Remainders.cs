using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Remainders
    {
        /*
         * Write a function that accepts two integers and returns the remainder of dividing the larger value by the smaller value.

        Divison by zero should throw a DivideByZeroException.
        */
        public static int Remainder(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            int larger = Math.Max(a, b);
            int smaller = Math.Min(a, b);

            return larger % smaller;

        }
    }
}
