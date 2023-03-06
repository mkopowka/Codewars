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
          return x.Sum(Convert.ToInt32);
        }
    }
}
