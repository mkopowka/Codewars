using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Given an array of numbers (in string format), you must return a string. The numbers correspond to the letters of the alphabet in reverse order: a=26, z=1 etc. You should also account for '!', '?' and ' ' that are represented by '27', '28' and '29' respectively.

    All inputs will be valid.
    */
    internal class Switchers
    {
        public static string Switcher(string[] x)
        {
            string result = "";

            foreach (string num in x)
            {
                switch (num)
                {
                    case "27":
                        result += "!";
                        break;
                    case "28":
                        result += "?";
                        break;
                    case "29":
                        result += " ";
                        break;
                    default:
                        int value = int.Parse(num);
                        result += (char)('a' + ('z' - value + 1));
                        break;
                }
            }

            return result;
        }
    }
}
