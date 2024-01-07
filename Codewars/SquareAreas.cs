using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Complete the function that calculates the area of the red square, when the length of the circular arc A is given as the input. Return the result rounded to two decimals.
     */
    internal class SquareAreas
    {
        public static double SquareArea(double A)
        {
            double radius = A / (2 * Math.PI / 4);
            double area = (Math.Pow(radius, 2));
            return Math.Round(area, 2);
        }
    }
}
