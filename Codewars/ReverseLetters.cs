using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ReverseLetters
    {
        public string ReverseLetter(string str)
        {
            string result = Regex.Replace(str, "[^a-zA-Z]", "");
            char[] charArray = result.ToCharArray();

            Array.Reverse(charArray);
            string reverse = new string(charArray);

            return reverse;
        }
    }
}
