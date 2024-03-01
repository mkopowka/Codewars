using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Write a function that removes every lone 9 that is inbetween 7s. */
    internal class SevenAte9
    {
        public static string SevenAteNine(string str)
        {
            StringBuilder result = new StringBuilder();
            bool sevenEncountered = false;

            foreach (char c in str)
            {
                if (c == '7')
                {
                    sevenEncountered = true;
                    result.Append(c);
                }
                else if (c == '9' && sevenEncountered)
                {
                    continue;
                }
                else
                {
                    sevenEncountered = false;
                    result.Append(c);
                }
            }

            return result.ToString();
        }

    }
}
