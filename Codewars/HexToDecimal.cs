using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class HexToDecimal
    {
        public static int HexToDec(string hexString)
        {
            int decimalValue = 0;
            try
            {
                if (hexString.StartsWith("-"))
                {
                    hexString = hexString.Substring(1);
                    decimalValue = -Convert.ToInt32(hexString, 16); 
                }
                else
                {
                    decimalValue = Convert.ToInt32(hexString, 16);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid hexadecimal input");
            }
            return decimalValue;
        }
    }
}
