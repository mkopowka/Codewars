using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * In this Kata, you will be given a string and your task will be to return a list of ints detailing the count of uppercase letters, lowercase, numbers and special characters, as follows.

Solve("*'&ABCDabcde12345") = [4,5,5,3]. 
--the order is: uppercase letters, lowercase, numbers and special characters.
    */
    internal class StringCharacters
    {
        public static int[] solve(String s)
        {
            int upperCount = 0, lowerCount = 0, digitCount = 0, specialCount = 0;

            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                {
                    upperCount++;
                }
                else if (Char.IsLower(c))
                {
                    lowerCount++;
                }
                else if (Char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                {
                    specialCount++;
                }
            }

            return new int[] { upperCount, lowerCount, digitCount, specialCount };
        }
    }
}
