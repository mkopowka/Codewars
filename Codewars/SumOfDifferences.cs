using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SumOfDifferences
    {
        public static int SumDifferencesDescending(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);

            int sum = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                sum += array[i] - array[i + 1];
            }

            return sum;
        }
    }
}
