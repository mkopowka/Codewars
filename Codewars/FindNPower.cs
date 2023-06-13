using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FindNPower
    {
        public static double Index(int[] array, int n)
        {
            if (n >= 0 && n < array.Length)
            {
                int element = array[n];
                return (long)Math.Pow(element, n);
            }
            else
            {
                return -1;
            }
        }
    }
}
