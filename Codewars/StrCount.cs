using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class StrCount
    {
        public static int StrCounts(string str, char letter)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
