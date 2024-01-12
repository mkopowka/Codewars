using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal static class Digit
    {
        /* Implement String#digit? which should return true if given object is a digit (0-9), false otherwise. */
        public static bool Digits(this string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length != 1)
            {
                return false;
            }

            char digitChar = s[0];
            return char.IsDigit(digitChar);
        }
    }
}
