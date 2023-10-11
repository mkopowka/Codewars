using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SumMinMax
    {
        public static int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 2)
            {
                return 0;
            }

            Array.Sort(numbers);

            int sum = 0;
            for (int i = 1;i<numbers.Length-1;i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
