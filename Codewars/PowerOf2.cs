using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class PowerOf2
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            BigInteger[] powers = new BigInteger[n + 1];

            for (int i = 0; i <= n; i++)
            {
                powers[i] = BigInteger.Pow(2, i);
            }

            return powers;
        }
    }
}
