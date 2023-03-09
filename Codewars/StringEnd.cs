using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class StringEnd
    {
        public static bool Solution(string str, string ending)
        {
            if (str.EndsWith(ending)) { return true; }
            else return false;
        }
    }
}
