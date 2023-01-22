using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SquareDigits
    {
        public int SquareDigit(int n)
        {
            string input = n.ToString();
            string result = "";
            foreach (char c in input)
            {
                int digit = int.Parse(c.ToString());
                result += (digit * digit);
            }
            return int.Parse(result);
        }
    }
}
