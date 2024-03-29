﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*  A balanced number is a number where the sum of digits to the left of the middle digit(s) and the sum of digits to the right of the middle digit(s) are equal.

    If the number has an odd number of digits, then there is only one middle digit. (For example, 92645 has one middle digit, 6.) Otherwise, there are two middle digits. (For example, the middle digits of 1301 are 3 and 0.)

    The middle digit(s) should not be considered when determining whether a number is balanced or not, e.g. 413023 is a balanced number because the left sum and right sum are both 5.

    The task
    Given a number, find if it is balanced, and return the string "Balanced" or "Not Balanced" accordingly. The passed number will always be positive.
    */
    internal class BalancedNumbers
    {
        public static string BalancedNumber(int number)
        {
            string numStr = number.ToString();
            int length = numStr.Length;
            int middleIndex = length / 2;

            int leftSum = 0;
            int rightSum = 0;


            for (int i = 0; i < middleIndex; i++)
            {
                leftSum += int.Parse(numStr[i].ToString());
            }

            for (int i = length - 1; i > middleIndex; i--)
            {
                rightSum += int.Parse(numStr[i].ToString());
            }

            return (leftSum == rightSum) ? "Balanced" : "Not Balanced";
        }
    }
}
