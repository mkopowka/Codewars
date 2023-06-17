using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FindNextSquares
    {
        public static long FindNextSquare(long num)
        {
            double final = Math.Sqrt(num);
            bool isSqr = final % 1 == 0;
            if (isSqr == true)
            {
                final++;
                final = final * final;
                long fi = Convert.ToInt64(final);
                return fi;
            }
            else
            {
                return -1;
            }
        }
}
