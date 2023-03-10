using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class RowSumOddNumber
    {
        public static long RowSumOddNumbers(long n)
        {
            
            long firstNumber = (n * (n - 1)) + 1;
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += firstNumber + (2 * i);
            }

            return sum;
        }
    }
}
