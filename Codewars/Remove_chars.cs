using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Remove_chars
    {
        public static string Remove_char(string s)
        {
            s.ToLower();
            s = s.Remove(s.Length - 1);
            string result = s.Remove(0, 1);
            return result;
        }
    }
}
