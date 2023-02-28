using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class RentalCarCosts
    {
        public int RentalCarCost(int d)
        {
            int result = 0;
            if (d < 3)
            {
                result = 40 * d;
            }
            else if (d >= 3 && d < 7)
            {
                result = 40 * d - 20;
            }
            if (d >= 7)
            {
                result = 40 * d - 50;
            }
            return result;
        }
    }
}
