using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Middle
    {
        public static string GetMiddle(string s)
        {
            int length = s.Length;
            int midIndex = length / 2;

            if (length % 2 == 0)
            {
                return s.Substring(midIndex - 1, 2);
            }
            else
            {
                return s.Substring(midIndex, 1);
            }
        }
    }
}
