using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class BinToDecimal
    {
        public static int BinaryToDecimal(string binary)
        {
            int decimalValue = Convert.ToInt32(binary, 2);
            return decimalValue;
        }
    }
}
