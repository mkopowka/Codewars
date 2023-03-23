using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Digitizes
    {
        public static long[] Digitize(long n)
        {
            if (n == 0)
            {
                return new long[] { 0 };
            }

            List<long> digits = new List<long>();

            while (n > 0)
            {
                digits.Add(n % 10);
                n /= 10;
            }

            return digits.ToArray();
        }
    }
}
