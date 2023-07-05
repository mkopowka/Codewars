using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FindLargestPairSum
    {
        public static int LargestPairSum(int[] numbers)
        {

            int largestSum = int.MinValue;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];
                    largestSum = Math.Max(largestSum, sum);
                }
            }

            return largestSum;
        }
    }
}
