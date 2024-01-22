using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Given an array/list of integers, find the Nth smallest element in the array.
     */
    internal class NthSmallests
    {
        public static int NthSmallest(int[] arr, int pos)
        {
            Array.Sort(arr);
            return arr[pos - 1];
        }
    }
}
