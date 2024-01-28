using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ValueString
    {
        /* Complete the solution so that it returns a formatted string. The return value should equal "Value is VALUE" where value is a 5 digit padded number. */
        public static string Solution(int value)
        {
            string formattedValue = $"{value:D5}";

            return $"Value is {formattedValue}";
        }
    }
}
