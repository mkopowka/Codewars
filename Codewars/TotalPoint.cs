using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class TotalPoint
    {
        public static int TotalPoints(string[] games)
        {
            int totalPoints = 0;
            foreach (string matchResult in games)
            {
                int x = int.Parse(matchResult.Split(':')[0]);
                int y = int.Parse(matchResult.Split(':')[1]);

                if (x > y)
                {
                    totalPoints += 3;
                }
                else if (x == y)
                {
                    totalPoints += 1;
                }
            }

            return totalPoints;
        }
    }
}
