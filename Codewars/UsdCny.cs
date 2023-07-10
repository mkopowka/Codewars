using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class UsdCny
    {
        public static string Usdcny(int usd)
        {
            double sum = usd * 6.75;
   
            return string.Format("{0:f2}", sum) + " Chinese Yuan";
        }
    }
}
