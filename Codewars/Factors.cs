using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Given a positive number n > 1 find the prime factor decomposition of n. The result will be a string with the following form :

     "(p1**n1)(p2**n2)...(pk**nk)"
    with the p(i) in increasing order and n(i) empty if n(i) is 1.

    Example: n = 86240 should return "(2**5)(5)(7**2)(11)"
    */
    internal class Factors
    {
        public static String factors(int lst)
        {
            if (lst <= 1)
            {
                return "";
            }

            string result = "";
            int currentPrime = 2;
            int count = 0;

            while (lst > 1)
            {
                if (lst % currentPrime == 0)
                {
                    lst /= currentPrime;
                    count++;

                    if (lst % currentPrime != 0)
                    {
                        result += $"({currentPrime}";

                        if (count > 1)
                        {
                            result += $"**{count}";
                        }

                        result += ")";
                        count = 0;
                    }
                }
                else
                {
                    currentPrime++;
                }
            }

            return result;
        }
    }
}
