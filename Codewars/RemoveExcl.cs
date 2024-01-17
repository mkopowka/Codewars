using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class RemoveExcl
    {
        /*Remove n exclamation marks in the sentence from left to right. n is positive integer. */
        public static string Remove(string s, int n)
        {
            int count = 0;
            char[] result = new char[s.Length];

            foreach (char c in s)
            {
                if (c == '!' && n > 0)
                {
                    n--;
                }
                else
                {
                    result[count++] = c;
                }
            }

            return new string(result, 0, count);
        }

    }
}
