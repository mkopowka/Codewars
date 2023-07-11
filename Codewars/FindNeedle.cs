using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FindNeedle
    {
        public static string FindNeedles(object[] haystack)
        {
            int index = Array.IndexOf(haystack, "needle");

            if (index != -1)
            {
                return "found the needle at position " + index;
            }
            else
            {
                return "needle not found";
            }
        }
    }
}
