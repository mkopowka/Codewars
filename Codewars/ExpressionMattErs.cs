using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Given three integers a ,b ,c, return the largest number obtained after inserting the following operators and brackets: +, *, () */
    internal class ExpressionMatters
    {
        public static int ExpressionsMatter(int a, int b, int c)
        {
            int result1 = (a + b) * c;
            int result2 = a * (b + c);
            int result3 = a + b + c;
            int result4 = a * b * c;

            return Math.Max(Math.Max(result1, result2), Math.Max(result3, result4));
        }
    }
}
