using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Write a function insert_dash(num) / insertDash(num) / InsertDash(int num) that will insert dashes ('-') between each two odd digits in num. For example: if num is 454793 the output should be 4547-9-3.

        Note that the number will always be non-negative (>= 0).
    */
    internal class InsertDashs
    {
        public static string InsertDash(int num)
        {
            string numStr = num.ToString();
            char[] resultArray = new char[numStr.Length * 2 - 1];
            int resultIndex = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                if (i > 0 && (numStr[i - 1] - '0') % 2 != 0 && (numStr[i] - '0') % 2 != 0)
                {
                    resultArray[resultIndex++] = '-';
                }

                resultArray[resultIndex++] = numStr[i];
            }

            return new string(resultArray, 0, resultIndex);
        }
    }
}
