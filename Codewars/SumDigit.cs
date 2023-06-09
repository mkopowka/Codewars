using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SumDigit
    {
        public static int SumDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }
    }
}
