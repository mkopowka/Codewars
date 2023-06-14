using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SumOfIntegerss
    {

        public static int SumOfIntegers(int a, int b)
        {
            int sum = 0;
            int start = Math.Min(a, b);
            int end = Math.Max(a, b);

            for (int i = start; i <= end; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
