using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Create a function that takes 2 integers in form of a string as an input, and outputs the sum (also as a string): */
    internal class StringSums
    {
        public static string StringsSum(string s1, string s2)
        {
            int num1 = string.IsNullOrEmpty(s1) ? 0 : int.Parse(s1);
            int num2 = string.IsNullOrEmpty(s2) ? 0 : int.Parse(s2);
            int sum = num1 + num2;
            return sum.ToString();
        }
    }
}
