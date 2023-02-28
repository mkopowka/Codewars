using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ToJadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            string[] words = phrase.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }

            string capitalizedString = string.Join(" ", words);
            return capitalizedString;
        }
    }
}
