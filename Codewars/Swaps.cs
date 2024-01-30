using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * When provided with a String, capitalize all vowels

For example:

Input : "Hello World!"

Output : "HEllO WOrld!"

Note: Y is not a vowel in this kata.
    */
    internal class Swaps
    {
        public static string Swap(string s)
        {
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char currentChar = chars[i];
                if (IsVowel(currentChar))
                {
 
                    chars[i] = char.ToUpper(currentChar);
                }

            }
            return new string(chars);
            
        }
        private static bool IsVowel(char character)
        {
            char upperChar = char.ToUpper(character);
            return upperChar == 'A' || upperChar == 'E' || upperChar == 'I' || upperChar == 'O' || upperChar == 'U';
        }
    }
}
