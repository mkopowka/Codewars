using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * This series of katas will introduce you to basics of doing geometry with computers.

        Point objects have fields X and Y.

        Write a function calculating distance between Point a and Point b.

        Input coordinates fit in range 
        −
        50
        ⩽
        �
        ,
        �
        ⩽
        50
        −50⩽x,y⩽50. Tests compare expected result and actual answer with tolerance of 1e-6.
    */
    internal class DistanceBetween
    {
        public static double DistanceBetweenPoints(Point a, Point b)
        {
            double deltaX = b.X - a.X;
            double deltaY = b.Y - a.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
