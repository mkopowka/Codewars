using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class DescendingOrders
    {
        public static int DescendingOrder(int num)
        {
            if(num == 0) return 0;
            List<int> digits = new List<int>();
            while (num > 0)
            {
                digits.Add(num % 10);
                num /= 10;
            }
            digits.Sort();
            digits.Reverse();
            return int.Parse(string.Join("", digits));
        }
    }
}
