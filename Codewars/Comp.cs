using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Comp
    {
        public static bool Comps(int[] a, int[] b)
        {
            return a != null && b != null && a.Select(v => v * v).OrderBy(v => v).SequenceEqual(b.OrderBy(v => v));
        }
    }
}
