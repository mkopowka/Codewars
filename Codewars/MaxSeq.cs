using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class MaxSeq
    {
        public static int MaxSequence(int[] arr)
        {
            if (arr.Length == 0)
                return 0;

            int maxSum = arr[0];
            int currentSum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                currentSum = Math.Max(arr[i], currentSum + arr[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}
