using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Divisors
    {
        public static int Divisor(int n)
        {
            int cnt = 0;
            for (int i = 1; i <= Math.Sqrt(n);i++)
            {
                if (n % i == 0)
                {

                    if (n / i == i)
                        cnt++;

                    else
                        cnt = cnt + 2;
                }
            }

            return cnt;
        }
    }
}
