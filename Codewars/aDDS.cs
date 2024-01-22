using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Create a function add(n)/Add(n) which returns a function that always adds n to any number &*/
    internal class Adds
    {
        public static Func<double, double> Add(double n)
        {
            return x => x + n;
        }
    }
}
