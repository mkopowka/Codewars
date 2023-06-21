using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Betweens
    {
        public static int[] Between(int a, int b)
        {
            int length = b - a + 1;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = a + i;
            }

            return result;
        }
    }
}
