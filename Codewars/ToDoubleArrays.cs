using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ToDoubleArrays
    {
        /*
         * Some really funny web dev gave you a sequence of numbers from his API response as an sequence of strings!

            You need to cast the whole array to the correct type.

            Create the function that takes as a parameter a sequence of numbers represented as strings and outputs a sequence of numbers.

            ie:["1", "2", "3"] to [1, 2, 3]

            Note that you can receive floats as well.
        */
        public static double[] ToDoubleArray(string[] stringArray)
        {
            return stringArray.Select(x => Double.Parse(x)).ToArray();
        }
    }
}
