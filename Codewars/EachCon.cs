using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*Create a method each_cons that accepts a list and a number n, and returns cascading subsets of the list of size n, like so: */
    internal class EachCon
    {
        public static IEnumerable<IEnumerable<int>> EachCons(int[] list, int n)
        {

            for (int i = 0; i <= list.Length - n; i++)
            {
                yield return list.Skip(i).Take(n);
            }
        }
    }
}
