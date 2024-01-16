using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{ /*
   * Your task is to return the sum of Triangular Numbers up-to-and-including the nth Triangular Number.
     Triangular Number: "any of the series of numbers (1, 3, 6, 10, 15, etc.) obtained by continued summation of the natural numbers 1, 2, 3, 4, 5, etc."
    */
    internal class SumTriangularNumber
    {
        public static int SumTriangularNumbers(int n)
        {
            if (n<0) return 0;
            return n * (n + 1) * (n + 2) / 6;
        }
    }
}
