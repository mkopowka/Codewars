using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class IsPanagram
    {
        public static bool IsPangram(string str)
        {
            int a = str.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count();
            if (a == 26) return true;
            else
                return false;
        }
    }
}
