using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Multiply
    {

        public static int Multiplies(int x)
        {
            if (x% 2 == 0) return x * 8; else return x * 9;  

        }
    }
}
