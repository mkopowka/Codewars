using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class StringRepeater
    {
        public static string RepeatStr(int n, string s)
        {
            return String.Concat(Enumerable.Repeat(s, n));
        }
    }
}
