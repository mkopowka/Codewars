using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class DisariumNumbers
    {
        public static string DisariumNumber(int number)
        {
            int temp = number;
            int length = number.ToString().Length;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, length);
                temp /= 10;
                length--;
            }

            return sum == number ? "Disarium !!" : "Not !!";
        }
    }
}
