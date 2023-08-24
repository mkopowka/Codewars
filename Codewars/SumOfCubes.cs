using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SumOfCubes
    {
        public long SumCubes(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                long cubedValue = (long)i * i * i;
                sum += cubedValue;
            }
            return sum;
        }
    }
}
