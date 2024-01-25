using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* I will give you an integer. Give me back a shape that is as long and wide as the integer. The integer will be a whole number between 1 and 50. */
    internal class GenerateShapes
    {
        public static string GenerateShape(int n)
        {
            return string.Join("\n", Enumerable.Repeat("".PadLeft(n, '+'), n));
        }
    }
}
