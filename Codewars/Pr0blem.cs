using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Make a function that returns the value multiplied by 50 and increased by 6. If the value entered is a string it should return "Error".

        Note: in C#, you'll always get the input as a string, so the above applies if the string isn't representing a double value.
    */
    internal class Pr0blem
    {
        public static string Problem(String a)
        {
            if (double.TryParse(a, out double number))
            {
                double result = number * 50 + 6;
                return result.ToString();
            }
            else
                return "Error";
        }
    }
    }
}
