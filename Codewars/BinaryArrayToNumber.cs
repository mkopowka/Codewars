using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class BinaryArrayToNumber
    {
        public static int binaryArrayToNumbers(int[] BinaryArray)
        {
            string binaryString = string.Join("", BinaryArray);
            int decimalValue = Convert.ToInt32(binaryString, 2);
            return decimalValue;
        }
    }
}
