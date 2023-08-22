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
            if (n >= 0)
            {
                if (n == 0)
                {
                    return 0;
                }
                else if (n < 13)
                {
                    return n - 1;
                }
                else
                {
                    return n - 2;
                }
            }
            else
            {
                return n;
            }
        }
    }
}
