using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class MinMax
    {
        /* Write a function that returns both the minimum and maximum number of the given list/array. */
        public static int[] minMaxs(int[] lst)
        {
            if (lst == null || lst.Length == 0)
            {
                return null;
            }

            int min = lst[0];
            int max = lst[0];

            for (int i = 1; i < lst.Length; i++)
            {
                if (lst[i] < min)
                {
                    min = lst[i];
                }

                if (lst[i] > max)
                {
                    max = lst[i];
                }
            }

            return new int[] { min, max };
        }
    }
}
