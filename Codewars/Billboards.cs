using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* You can print your name on a billboard ad. Find out how much it will cost you. Each character has a default price of £30, but that can be different if you are given 2 parameters instead of 1 (allways 2 for Java).

        You can not use multiplier "*" operator.
    */
    internal class Billboards
    {
        public static double Billboard(string name, double price = 30)
        {
            double nameCost = 0;

            foreach (char character in name)
            {
                nameCost += price;
            }

            return nameCost;
        }
    }
}
