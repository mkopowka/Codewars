using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SaleHotDogs
    {
        public static int SaleHotDog(int n)
        {
            if (n < 5) { return 100 * n; }
            else if (n >= 5 && n < 10) { return 95 * n; }
            else return 90 * n;
        }
    }
}
