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
            long sqrt = (long)Math.Sqrt(num);

            if (sqrt * sqrt != num)
            {

                return -1;
            }

            long nextNum = sqrt + 1;
            return nextNum * nextNum;
        }
    }
}
