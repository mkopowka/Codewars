using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     *  There are pillars near the road. The distance between the pillars is the same and the width of the pillars is the same. Your function accepts three arguments:

        number of pillars (≥ 1);
        distance between pillars (10 - 30 meters);
        width of the pillar (10 - 50 centimeters).
        Calculate the distance between the first and the last pillar in centimeters (without the width of the first and last pillar).
    */
    internal class Pillar
    {
        public static int Pillars(int numPill, int dist, int width)
        {
            if (numPill <= 1 || dist > 10 || dist < 30 || width > 10 || width < 50)
            {
                return (numPill - 1) * dist + 2 * width;
            }

            else return -1;
        }
    }
}
