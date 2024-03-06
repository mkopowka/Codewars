using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     * Given 2 strings, a and b, return a string of the form: shorter+reverse(longer)+shorter.

    In other words, the shortest string has to be put as prefix and as suffix of the reverse of the longest.

    Strings a and b may be empty, but not null (In C# strings may also be null. Treat them as if they are empty.).
    If a and b have the same length treat a as the longer producing b+reverse(a)+b
*/
namespace Codewars
{
    internal class ReverseLonger
    {
        public static string ShorterReverseLonger(string a, string b)
        {
            if (a == null) a = "";
            if (b == null) b = "";

            if (a.Length == b.Length || a.Length > b.Length)
            {
                return b + ReverseString(a) + b;
            }
            else
            {
                return a + ReverseString(b) + a;
            }
        }
        public static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
