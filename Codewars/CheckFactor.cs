using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CheckFactor
    {
        public static bool CheckForFactor(int num, int factor)
        {
            if (num % factor == 0)
                return true;
            else
                return false;
        }
    }
}
