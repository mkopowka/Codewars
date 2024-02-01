using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Definition
    A number is a Special Number if it’s digits only consist 0, 1, 2, 3, 4 or 5

    Given a number determine if it special number or not .
    */
    internal class SpecialNumbers
    {
        public static string SpecialNumber(int number)
        {
            string digits = number.ToString();

            foreach (char digit in digits)
            {
                if (digit < '0' || digit > '5')
                {
                    return "NOT!!";
                }
            }

            return "Special!!";
        }
    }
}
