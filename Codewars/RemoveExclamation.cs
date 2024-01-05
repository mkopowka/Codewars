using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Remove all exclamation marks from sentence but ensure a exclamation mark at the end of string. 
     * For a beginner kata, you can assume that the input data is always a non empty string, no need to verify it.

      */
    internal class RemoveExclamation
    {
        public static string Remove(string s)
        {
            string withoutExclamation = s.Replace("!", "");
            string result = withoutExclamation + "!";
            return result;

        }
    }
}
