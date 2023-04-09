using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class RoundNextTo5
    {
        public static int RoundToNextMultipleOf5(int num)
        {

            int remainder = num % 5;
            if (remainder == 0) // liczba jest już wielokrotnością 5
            {
                return num;
            }
            else if (num >= 0) // liczba dodatnia
            {
                return num  + (5 - remainder);
            }
            else // liczba ujemna
            {
                return num - remainder;
            }
        }
    }
}
