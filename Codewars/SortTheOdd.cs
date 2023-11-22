using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SortTheOdd
    {
        public static int[] SortArray(int[] array)
        {

            var oddNumbers = array.Where(num => num % 2 != 0).OrderBy(num => num).ToArray();
            for (int i = 0,j=0; i < array.Length; i++)
            {
                if (array[i] % 2!=0)
                {
                    array[i] = oddNumbers[j];
                    j++;
                }
            }
            return array;
        }
    }
}
