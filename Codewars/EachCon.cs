using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class EachCon
    {
        public static IEnumerable<IEnumerable<int>> EachCons(int[] list, int n)
        {
            if (n <= 0 || n > list.Length)
            {
                throw new ArgumentException("Invalid value of n");
            }

            for (int i = 0; i <= list.Length - n; i++)
            {
                yield return list.Skip(i).Take(n);
            }
        }
    }
}
