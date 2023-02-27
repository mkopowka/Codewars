using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Bouncing
    {
        public static int bouncingBall(double h, double bounce, double window)
        {
            int count = 0;
            if (h != 0 && bounce < 1 && bounce > 0 && window < h)
            {
                count = 1;
                h = h * bounce;
                while (h > window)
                {
                    count += 2;
                    h = h * bounce;

                }
                return count;
            }
            else
                return -1;
  
        }
    }
}
