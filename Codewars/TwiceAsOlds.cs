using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class TwiceAsOlds
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            int yearsAgo = Math.Abs(dadYears - 2 * sonYears);
            return yearsAgo;
        }
    }
}
