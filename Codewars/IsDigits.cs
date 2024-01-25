using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Given a string s, write a method (function) that will return true if its a valid single integer or floating number or false if its not. */
    internal class IsDigits
    {
        public static bool IsDigit(string s)
        {
            return double.TryParse(s, out _);
        }
    }
}
