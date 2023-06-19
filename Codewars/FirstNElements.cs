using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FirstNElements
    {
        public static int[] Take(int[] arr, int n)
        {
            if (n >= arr.Length)
            {
                return arr;
            }
            else
            {
                int[] result = new int[n];
                Array.Copy(arr, result, n);
                return result;
            }
        }
    }
}
