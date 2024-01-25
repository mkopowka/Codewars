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
            System.Text.StringBuilder result = new System.Text.StringBuilder();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result.Append("+");
                }
                if (i < n - 1)
                {
                    result.AppendLine();
                }
            }

            return result.ToString();
        }
    }
}
