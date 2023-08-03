using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SeriesSum
    {
        public static string seriesSum(int n)
        {
            return (from i in Enumerable.Range(0, n) select 1.0 / (3 * i + 1)).Sum().ToString("0.00");
        }
    }
}
