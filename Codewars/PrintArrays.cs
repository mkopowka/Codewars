using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Input: Array of elements

        ["h","o","l","a"]

        Output: String with comma delimited elements of the array in th same order.

        "h,o,l,a"

        Note: if this seems too simple for you try the next level

        Note2: the input data can be: boolean array, array of objects, array of string arrays, array of number arrays... 😕
    */
    internal class PrintArrays
    {
        public static string PrintArray(object[] array)
        {
            string result = string.Join(",", array.Select(element => element.ToString()));

            return result;
        }
    }
}
