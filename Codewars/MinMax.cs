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
            return new int[] { lst.Min(), lst.Max() };
        }
    }
}
