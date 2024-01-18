using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * The cockroach is one of the fastest insects. Write a function which takes its speed in km per hour and returns it in cm per second, rounded down to the integer (= floored).

        For example:

        1.08 --> 30
        Note! The input is a Real number (actual type is language dependent) and is >= 0. The result should be an Integer.
    */
    internal class CockroachSpeeds
    {
        public static int CockroachSpeed(double x)
        {
            return (int)Math.Floor(x * 1000 / 36);
        }
    }
}
