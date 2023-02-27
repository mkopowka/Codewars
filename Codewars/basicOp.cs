using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class basicOp
    {
        public static double basicOps(char operation, double value1, double value2)
        {
            if (operation == '+') return value1 + value2;
            if (operation=='-') return value1 - value2;
            if (operation=='*') return value1 * value2;
            if (operation == '/') return value1 / value2;
            else return -1;
        }
    }
}
