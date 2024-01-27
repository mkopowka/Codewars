using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Write a program that outputs the top n elements from a list. */
    internal class Largests
    {
        public static List<int> Largest(int n, List<int> xs)
        {
            if (n <= 0 || xs == null || xs.Count == 0)
            {
                return new List<int>();
            }
            return xs.OrderByDescending(x => x).Take(n).ToList();
        }
    }
}
