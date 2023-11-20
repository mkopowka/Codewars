using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Odd
    {
        public static List<int> Odds(List<int> values) =>
      // arrow it
      values.Where( a => a%2!=0 )
            .ToList();
    }
}
