using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Find the sum of all multiples of n below m

        Keep in Mind
        n and m are natural numbers (positive integers)
        m is excluded from the multiples
    */
    internal class SumMuls
    {
        public static int SumMul(int n, int m)
        {
            if (n <= 0 || m <= 0)
            {
                throw new ArgumentException("Both n and m must be positive integers.");
            }

            if (m <= n)
            {
                throw new ArgumentException("m must be greater than n.");
            }

            int sum = 0;

            for (int i = n; i < m; i += n)
            {
                sum += i;
            }

            return sum;
        }
    }
}
