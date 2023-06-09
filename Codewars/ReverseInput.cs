using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ReverseInput
    {
        public static string Reverse(string text)
        {
            text = text.Trim();
            string[] words = Regex.Split(text, @"(\s+)");

            Array.Reverse(words);
            string reversed = string.Concat(words);

            return reversed;
        }
    }
}
