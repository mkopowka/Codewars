using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class HoopCount
    {
        public static string HoopCounts(int n)
        {
            string s = " ";

            if (n < 10)
            {
                s = "Keep at it until you get it";
            }
            else if (n > 10)
            {
                s = "Great, now move on to tricks";
            }
            return s;
        }
    }
}
