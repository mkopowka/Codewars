using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class RemoveExclamationMark
    {
        public static string Remove(string s)
        {
            char lastChar = s[s.Length - 1];
            if (lastChar == '!')
            {
                s = s.Substring(0, s.Length - 1);
            }
            return s;
        }
    }
}
