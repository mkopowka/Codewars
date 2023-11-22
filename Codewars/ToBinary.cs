using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ToBinary
    {
        public static int ToBinarys(int n)
        {
            if(n == 0) return 0;
            int binary = 0;
            int baseValue = 1;
            while(n > 0)
            {
                int rem = n % 2;

                binary += rem * baseValue;
                baseValue *= 10;

                n /= 2;
            }

            return binary;
        }
    }
}
