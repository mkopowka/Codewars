using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*Given an array of Boolean values and a logical operator, return a Boolean result based on sequentially applying the operator to the values in the array.

*/
    internal class LogicalCalcs
    {
        public static bool LogicalCalc(bool[] array, string op)
        {
            if (array == null || array.Length == 0)
            {
                return false;
            }

            bool result = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (op == "AND")
                {
                    result = result && array[i];
                }
                else if (op == "OR")
                {
                    result = result || array[i];
                }
                else if (op == "XOR")
                {
                    result = result != array[i];
                }
            }

            return result;
        }
    }
}
