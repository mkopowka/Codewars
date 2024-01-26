using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    /* The vowel substrings in the word codewarriors are o,e,a,io. The longest of these has a length of 2. Given a lowercase string that has alphabetic characters only (both vowels and consonants) and no spaces, return the length of the longest vowel substring. Vowels are any of aeiou.
     * */
    internal class LongestVowel
    {
        public static int Solve(string str)
        {
            return Regex.Split(str, "[^aeiou]+").Max(e => e.Length);
        }
    }
}
