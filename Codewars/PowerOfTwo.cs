using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class PowerOfTwo
    {
        public static bool PowerOfTwos(int n)
        {
            return n > 0 && (n & (n - 1)) == 0;

        }
    }
}
