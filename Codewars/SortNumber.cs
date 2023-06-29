using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SortNumber
    {
        public int[] SortNumbers(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return new int[0];
            }

            Array.Sort(nums);

            return nums;

        }

    }
}
