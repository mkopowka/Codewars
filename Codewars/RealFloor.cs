using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class RealFloor
    {
        public static int GetRealFloor(int n)
        {
            if (n > 12) return n - 2;
            if (n > 0) return n - 1;
            return n;
        }
    }
}
