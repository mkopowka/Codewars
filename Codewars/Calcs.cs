using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Given a string, turn each character into its ASCII character code and join them together to create a number - let's call this number total1:

        'ABC' --> 'A' = 65, 'B' = 66, 'C' = 67 --> 656667
        Then replace any incidence of the number 7 with the number 1, and call this number 'total2':

        total1 = 656667
                      ^
        total2 = 656661
                      ^
        Then return the difference between the sum of the digits in total1 and total2:

          (6 + 5 + 6 + 6 + 6 + 7)
        - (6 + 5 + 6 + 6 + 6 + 1)
        -------------------------
                       6
    */
    internal class Calcs
    {
        public static Int32 Calc(String s)
        {
            string total1 = string.Join("", Array.ConvertAll(s.ToCharArray(), c => (int)c));
            string total2 = total1.Replace('7', '1');
            int sumTotal1 = 0;
            foreach (char digit in total1)
            {
                if (char.IsDigit(digit))
                {
                    sumTotal1 += int.Parse(digit.ToString());
                }
            }

            int sumTotal2 = 0;
            foreach (char digit in total2)
            {
                if (char.IsDigit(digit))
                {
                    sumTotal2 += int.Parse(digit.ToString());
                }
            }
            return sumTotal1 - sumTotal2;
        }
    }
}
