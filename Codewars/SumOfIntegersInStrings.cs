using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Your task in this kata is to implement a function that calculates the sum of the integers inside a string. For example, in the string "The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog", the sum of the integers is 3635.

        Note: only positive integers will be tested.
    */
    internal class SumOfIntegersInStrings
    {
        public static int SumOfIntegersInString(string s)
        {
            MatchCollection matches = Regex.Matches(s, @"-?\d+");
            int sum = 0;
            int[] result = new int[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                result[i] = int.Parse(matches[i].Value);
            }

            for (int i = 0;i<result.Length;i++)
            {
                sum += result[i];
            }
            return sum;
        }
    }
}
