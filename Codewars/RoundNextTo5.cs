using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class RoundNextTo5
    {
        public static int RoundToNextMultipleOf5(int num)
        {
            int n = 0;
            while (n % 5 != 0) n++;
            return n;
        }
    }
}
