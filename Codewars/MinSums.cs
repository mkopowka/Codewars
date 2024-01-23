using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Given an array of integers , Find the minimum sum which is obtained from summing each Two integers product */
    internal class MinSums
    {
        public static int MinSum(int[] a)
        {
            Array.Sort(a);

            int sum = 0;
            for (int i = 0, j = a.Length - 1; i < j; i++, j--)
            {
                sum += a[i] * a[j];
            }

            return sum;
        }
    }
}
