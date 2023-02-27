using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SquareSums
    {
        public static int SquareSum(int[] numbers)
        {
            int sum = 0;
            int b = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                b=numbers[i] * numbers[i];
                sum += b;
            }

            return sum;
        }
    }
}
