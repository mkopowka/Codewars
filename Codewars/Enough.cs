using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Enough
    {
        public static int Enoughs(int cap, int on, int wait)
        {
            int availableSeats = cap - on;

            if (availableSeats >= wait)
            {
                return 0;
            }
            else
            {
                return wait - availableSeats;
            }
        }
    }
}
