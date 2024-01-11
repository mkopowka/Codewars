using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*Write a function which removes from string all non-digit characters and parse the remaining to number. E.g: "hell5o wor6ld" -> 56 */
    internal class getNumberFromStringZ
    {
        public static int getNumberFromString(string s)
        {
            return int.Parse(string.Concat(s.Where(char.IsDigit)));
        }
    }
}
