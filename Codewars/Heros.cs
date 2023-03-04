using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Heros
    {
        public static bool Hero(int bullets, int dragons)
        {
            if (bullets / dragons >= 2)
            {
                return true;
            }
            else return false;
        }
    }
}
