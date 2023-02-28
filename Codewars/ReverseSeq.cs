using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ReverseSeq
    {
        public static int[] ReverseSeqs(int n)
        {
            int[] result = new int[n];
            for(int i = 0; i < n;i++)
            {
                result[i] = n-i;
            }
            return result;
        }
    }
}
