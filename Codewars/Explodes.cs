using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Given a string made of digits [0-9], return a string where each digit is repeated a number of times equals to its value.*/
    internal class Explodes
    {
        public static string Explode(string s)
        {
            StringBuilder result = new StringBuilder();

            foreach (char digitChar in s)
            {
                if (char.IsDigit(digitChar))
                {
                    int digitValue = int.Parse(digitChar.ToString());
                    result.Append(new string(digitChar, digitValue));
                }
                else
                {
                    result.Append(digitChar);
                }
            }

            return result.ToString();
        }
    }
}
