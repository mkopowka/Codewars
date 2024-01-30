using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * In this exercise, a string is passed to a method and a new string has to be returned with the first character of each word in the string.

        For example:

        "This Is A Test" ==> "TIAT"
        Strings will only contain letters and spaces, with exactly 1 space between words, and no leading/trailing spaces.
    */
    internal class MakeStrings
    {
        public static string MakeString(string s)
        {
            string[] words = s.Split(' ');

            string result = "";
            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    result += word[0];
                }
            }

            return result;
        }
    }
}
