using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* that takes in a string and replaces all the vowels [a,e,i,o,u] with their respective positions within that string. */
    internal class Vowel2Indexes
    {
        public static string Vowel2Index(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];

                if ("aeiouAEIOU".IndexOf(currentChar) != -1)
                {
                    result.Append((i + 1).ToString());
                }
                else
                {
                    result.Append(currentChar);
                }
            }

            return result.ToString();
        }
    }
}
