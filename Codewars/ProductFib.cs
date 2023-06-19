using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ProductFib
    {
        public static ulong[] ProductFibs(ulong prod)
        {
            ulong fib1 = 0;
            ulong fib2 = 1;

            while (fib1 * fib2 < prod)
            {
                ulong temp = fib1;
                fib1 = fib2;
                fib2 = temp + fib2;
            }

            return new ulong[] { fib1, fib2, (ulong)(fib1 * fib2 == prod ? 1 : 0) };
        }
    }
}
