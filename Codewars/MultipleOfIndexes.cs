using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Return a new array consisting of elements which are multiple of their own index in input array (length > 1). */
    //todo
    internal class MultipleOfIndexes
    {
        public static List<int> MultipleOfIndex(List<int> xs)
        {
            List<int> result = new List<int>();

            for (int i = 1; i < xs.Count; i++)
            {
                if (xs[i] % i == 0)
                {
                    result.Add(xs[i]);
                }
            }

            return result;
        }
    }
}
