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
            int sum = 0;
            
            for(int i = 0; i < ClassPoints.Length; i++)
            {
                sum = sum + ClassPoints[i];
            }
            double avg = sum/ClassPoints.Length;
            if (avg > YourPoints)
            {
                return false;
            }
            else
                return true;
        }
    }
}
