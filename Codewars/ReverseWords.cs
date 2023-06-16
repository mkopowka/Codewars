using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ReverseWords
    {
        public static string ReverseWord(string str)
        {
            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                Array.Reverse(chars);
                words[i] = new string(chars);
            }

            string reversedSentence = string.Join(" ", words);

            return reversedSentence;
        }
    }
}
