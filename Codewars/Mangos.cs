using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Mangos
    {
        public static int Mango(int quantity, int price)
        {
            int setOfTrhee = quantity / 3;
            int remainingMangoes =quantity % 3;

            int totalCost = (setOfTrhee * 2 + remainingMangoes) * price;

            return totalCost;
        }
    }
}
