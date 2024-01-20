using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Given a string and an array of integers representing indices, capitalize all letters at the given indices.

        For example:

        capitalize("abcdef",[1,2,5]) = "aBCdeF"
        capitalize("abcdef",[1,2,5,100]) = "aBCdeF". There is no index 100.
        The input will be a lowercase string with no spaces and an array of digits.

        Good luck!
    */
    internal class Capitalizes
    {
        public static string Capitalize(string s, List<int> idxs)
        {
            return idxs.All(index => index >= 0 && index < s.Length)
                ? new string(s.Select((c, i) => idxs.Contains(i) ? char.ToUpper(c) : c).ToArray())
                : "Invalid indices provided.";
        }
    }
}
