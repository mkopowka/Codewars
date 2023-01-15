using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Maps
    {
        public static int[] Map(int[] x)
        {

            for (int i = 0; i < x.Length; i++)
            {
                x[i] *= 2;
            }

            return x;
        }
    }
}
