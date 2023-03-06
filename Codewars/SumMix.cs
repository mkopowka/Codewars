using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SumMix
    {
        public static int SumMixs(object[] x)
        {
            int total = 0;
            foreach (object item in x)
            {
                if (item is int)
                {
                    total += (int)item;
                }
                else if (item is string && int.TryParse((string)item, out int intValue))
                {
                    total += intValue;
                }
            }
            return total;
        }
    }
}
