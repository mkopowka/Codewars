using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class DutyFrees
    {
        public static int DutyFree(int normPrice, int Discount, int hol)
        {
            double savingsPerBottle = normPrice * (Discount / 100.0);
            int bottlesNeeded = (int)(hol / savingsPerBottle);
            return bottlesNeeded;
        }
    }
}
