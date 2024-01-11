using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ParseFs
        /* Write function parseFloat which takes an input and returns a number or Nothing if conversion is not possible. */
    {
        public static double? ParseF(object s = null)
        {
            if (s != null && double.TryParse(s.ToString(), out double result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
