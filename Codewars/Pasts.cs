using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Pasts
    {
        public static int Past(int h, int m, int s)
        {
            return h* 3600000 + m * 60000 + s * 1000;
        }
    }
}
