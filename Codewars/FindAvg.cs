using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FindAvg
    {
        public static int FindAverage(int[] nums)
        {
            int count = nums.Length;
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += nums[i];
            }
            sum /= count;
            return sum;
        }
    }
}
