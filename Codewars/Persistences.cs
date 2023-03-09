using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Persistences
    {
        public static int Persistence(long n)
        {
            int count = 0;

            while (n >= 10)
            {
                long product = 1;
                while (n > 0)
                {
                    long digit = n % 10;
                    product *= digit;
                    n /= 10;
                }
                n = product;
                count++;
            }

            return count;
        }
    }
}
