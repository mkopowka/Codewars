using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* You must implement a function that returns the difference between the largest and the smallest value in a given list / array (lst) received as the parameter. */
    internal class MaxDifff
    {
        public int MaxDiff(int[] lst)
        {
           int min = lst.Min();
           int max = lst.Max();

            if (lst.Length == 0)
            {
                return 0;
            }
            return max - min;
        }
    }
}
