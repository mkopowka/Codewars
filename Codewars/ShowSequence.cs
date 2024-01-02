using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ShowSequence
    {
        public static string ShowSequences(int n)
        {
            if (n < 0)
            {
                return $"{n}<0";
            }

            if (n == 0)
            {
                return "0=0";
            }

            int sum = 0;
            string sequence = "0";

            for (int i = 1; i <= n; i++)
            {
                sequence += "+" + i;
                sum += i;
            }

            return $"{sequence} = {sum}";
        }
    }
}
