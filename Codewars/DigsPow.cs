using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class DigsPow
    {
        public static long digPow(int n, int p)
        {
            int sum = 0;
            int temp = n;
            int digitCount = (int)Math.Floor(Math.Log10(n) + 1); 

            for (int i = digitCount + p - 1; i >= p; i--)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, i);
                temp /= 10;
            }

            if (sum % n == 0)
            {
                return sum / n;
            }
            else
            {
                return -1;
            }
        }
    }
}
