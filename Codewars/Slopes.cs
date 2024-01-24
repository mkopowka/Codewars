using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Given an array of 4 integers
[a,b,c,d] representing two points (a, b) and (c, d), return a string representation of the slope of the line joining these two points.
    */
    internal class Slopes
    {
        public String CalclulateSlope(int[] points)
        {
            int a = points[0];
            int b = points[1];
            int c = points[2];
            int d = points[3];

            if (c - a == 0)
            {
                return "undefined";
            }
            double slopeValue = (double)(d - b) / (c - a);
            if (slopeValue == 0)
            {
                return "0";
            }

            return slopeValue.ToString();
        }
    }
}
