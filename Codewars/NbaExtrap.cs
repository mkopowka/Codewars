using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* 
     * An NBA game runs 48 minutes (Four 12 minute quarters). Players do not typically play the full game, subbing in and out as necessary. Your job is to extrapolate a player's points per game if they played the full 48 minutes.

Write a function that takes two arguments, ppg (points per game) and mpg (minutes per game) and returns a straight extrapolation of ppg per 48 minutes rounded to the nearest tenth. Return 0 if 0.
    */
    internal class NbaExtrap
    {
        public static double NbaExtraps(double ppg, double mpg)
        {
            if(ppg==0 || mpg==0) { return 0; }
            double result = (ppg / mpg) * 48;

            double round = Math.Round(result,1);

            return round;
        }
    }
}
