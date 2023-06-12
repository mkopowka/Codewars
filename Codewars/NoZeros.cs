using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class NoZeros
    {
        public static int NoBoringZeros(int number)
        {
            if (number == 0)
                return 0;

            while (number % 10 == 0)
            {
                number /= 10;
            }

            return number;
        }
    }
}
