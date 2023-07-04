using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class MaxDiffLength
    {
        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length == 0 || a2.Length == 0)
                return -1;

            int maxLengthDiff = int.MinValue;

            foreach (string x in a1)
            {
                foreach (string y in a2)
                {
                    int lengthDiff = Math.Abs(x.Length - y.Length);
                    if (lengthDiff > maxLengthDiff)
                        maxLengthDiff = lengthDiff;
                }
            }

            return maxLengthDiff;
        }
    }
}
