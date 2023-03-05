using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class LoverDetectors
    {
        public static bool lovefunc(int flower1, int flower2)
        {
            if(flower1%2 == 0 && flower2%2 !=0 || flower2 % 2 == 0 && flower1 % 2 != 0) { return true; }
            else { return false; }
        }
    }
}
