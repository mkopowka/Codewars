using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Find the sum of the odd numbers within an array, after cubing the initial integers.  */
    internal class CubeOdds
    {
        public static int CubeOdd(int[] arr)
        {

            int sum = 0;
            foreach (int number in arr)
            {
                if (number % 2 != 0)
                {
                    sum += (int)Math.Pow(number, 3);
                }
            }

            return sum;
        }
    }
}
