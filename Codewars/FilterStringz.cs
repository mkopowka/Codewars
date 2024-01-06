using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FilterStringz
    {
        /*
         * Filter the number
            Oh, no! The number has been mixed up with the text. Your goal is to retrieve the number from the text, can you return the number back to its original state?

            Task
            Your task is to return a number from a string.

            Details
            You will be given a string of numbers and letters mixed up, you have to return all the numbers in that string in the order they occur.
            return int.Parse(new String(s.Where(Char.IsDigit).ToArray()));
        */

        public static int FilterString(string s)
        {
            string pattern = @"\d+";

            MatchCollection matches = Regex.Matches(s, pattern);
            string result = "";
            foreach (Match match in matches)
            {
                result += match.Value;
            }

            return int.Parse(result);
        }
    }
}
