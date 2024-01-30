using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Your task is to write a function toLeetSpeak that converts a regular english sentence to Leetspeak.

More about LeetSpeak You can read at wiki -> https://en.wikipedia.org/wiki/Leet

Consider only uppercase letters (no lowercase letters, no numbers) and spaces.

For example:

toLeetSpeak("LEET") returns "1337"
In this kata we use a simple LeetSpeak dialect. Use this alphabet:

{
  A : '@',
  B : '8',
  C : '(',
  D : 'D',
  E : '3',
  F : 'F',
  G : '6',
  H : '#',
  I : '!',
  J : 'J',
  K : 'K',
  L : '1',
  M : 'M',
  N : 'N',
  O : '0',
  P : 'P',
  Q : 'Q',
  R : 'R',
  S : '$',
  T : '7',
  U : 'U',
  V : 'V',
  W : 'W',
  X : 'X',
  Y : 'Y',
  Z : '2'
}
*/
namespace Codewars
{
    internal class TooLetSpeak
    {
        public static string ToLeetSpeak(string str)
        {
            Dictionary<char, char> leetAlphabet = new Dictionary<char, char>
        {
            {'A', '@'},
            {'B', '8'},
            {'C', '('},
            {'D', 'D'},
            {'E', '3'},
            {'F', 'F'},
            {'G', '6'},
            {'H', '#'},
            {'I', '!'},
            {'J', 'J'},
            {'K', 'K'},
            {'L', '1'},
            {'M', 'M'},
            {'N', 'N'},
            {'O', '0'},
            {'P', 'P'},
            {'Q', 'Q'},
            {'R', 'R'},
            {'S', '$'},
            {'T', '7'},
            {'U', 'U'},
            {'V', 'V'},
            {'W', 'W'},
            {'X', 'X'},
            {'Y', 'Y'},
            {'Z', '2'}
        };

            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (leetAlphabet.ContainsKey(charArray[i]))
                {
                    charArray[i] = leetAlphabet[charArray[i]];
                }
            }

            return new string(charArray);
        }
    }
}
