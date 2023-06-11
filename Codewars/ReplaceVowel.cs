using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ReplaceVowel
    {
        public static string Replace(string s)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            foreach (char vowel in vowels)
            {
                s = s.Replace(vowel, '!');
            }

            return s;
        }
    }
}
