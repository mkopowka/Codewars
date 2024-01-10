using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Longests
    {
        /* Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.
         * */
        public static string Longest(string s1, string s2)
        {
            char[] combinedChars = (s1 + s2).ToCharArray();
            char[] distinctSortedChars = combinedChars.Distinct().OrderBy(c => c).ToArray();
            string result = new string(distinctSortedChars);

            return result;
        }
    }
}
