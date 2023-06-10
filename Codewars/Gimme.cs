using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Gimme
    {
        public static int Gimmes(double[] inputArray)
        {
            return Array.IndexOf(inputArray, inputArray.OrderBy(x => x).ToArray()[1]);
        }
    }
}
