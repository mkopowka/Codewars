using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Factorials
    {
        public static ulong Factorial(int n)
        {
            if(n == 0 || n==1) return 1;
            ulong result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= (ulong)i;
            }

            return result;
        }
    }
}
