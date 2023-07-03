using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Strays
    {
        public static int Stray(int[] numbers)
        {
            int result = 0;
            foreach (int num in numbers)
            {
                result ^= num;
            }
            return result;
        }
    }
}
