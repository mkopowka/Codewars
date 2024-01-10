using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class MenFromBoyz
    {
        /* Given an array/list [] of n integers , Separate The even numbers from the odds , or Separate the men from the boys */
        public static int[] MenFromBoys(int[] a)
        {
            int[] evenNumbers = a.Distinct().Where(x => x % 2 == 0).OrderBy(x => x).ToArray();
            int[] oddNumbers = a.Distinct().Where(x => x % 2 != 0).OrderByDescending(x => x).ToArray();

            return evenNumbers.Concat(oddNumbers).ToArray();
        }
    }
}
