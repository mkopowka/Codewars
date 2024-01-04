using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* 
     * Given a mixed array of number and string representations of integers, add up the non-string integers and subtract the total of the string integers.

            Return as a number.
    */
    internal class DivCons
    {
        public static int DivCon(Object[] objArray)
        {
            int sumNonStringIntegers = 0;
            int sumStringIntegers = 0;

            foreach (var item in objArray)
            {
                if (item is int)
                {
                    sumNonStringIntegers += (int)item;
                }
                else if (item is string && int.TryParse((string)item, out int intValue))
                {
                    sumStringIntegers += intValue;
                }
            }

            return sumNonStringIntegers - sumStringIntegers;
        }
    }
}
