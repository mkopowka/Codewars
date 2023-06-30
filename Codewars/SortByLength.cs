using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SortByLength
    {
        public static string[] SortByLengths(string[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                string temp = array[i];

                int j = i - 1;
                while (j >= 0 && temp.Length < array[j].Length)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            return array;
        }
    }
}
