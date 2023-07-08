using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FindNb
    {
        public static long findNbs(long m)
        {
            long sum = 0;
            long n = 1;

            while (sum < m)
            {
                sum += (long)Math.Pow(n, 3);
                n++;
            }

            if (sum == m)
            {
                return n - 1;
            }
            else
            {
                return -1;
            }
        }
}
