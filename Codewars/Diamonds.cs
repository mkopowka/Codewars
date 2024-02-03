using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Diamonds
    {
        public static string print(int n)
        {
            StringBuilder diamond = new StringBuilder();

            // Upper half of the diamond
            for (int i = 0; i < n / 2 + 1; i++)
            {
                diamond.Append(new string(' ', n / 2 - i));
                diamond.Append(new string('*', 2 * i + 1));
                diamond.Append('\n');
            }

            // Lower half of the diamond
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                diamond.Append(new string(' ', n / 2 - i));
                diamond.Append(new string('*', 2 * i + 1));
                diamond.Append('\n');
            }

            return diamond.ToString();
        }
    }
}
