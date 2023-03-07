using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class BetterThanAverage
    {
        public static bool BetterThanAverages(int[] ClassPoints, int YourPoints)
        {
            return YourPoints > ClassPoints.Average();
        }
    }
}
