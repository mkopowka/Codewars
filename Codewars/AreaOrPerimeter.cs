using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class AreaOrPerimeter
    {
        public static int AreaOrPerimeters(int l, int w)
        {
            if (l == w)
            {
                return l * w;
            }
            else
                return 2 * l + 2 * w;
        }
    }
}
