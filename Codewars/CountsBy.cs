using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CountsBy
    {
        public int[] CountBy(int x, int n)
        {
            int[] z = new int[n];

            for(int i = 0; i < n;i++)
            {
                z[i] = x * (i+1);
            }

            return z;
        }
    }
}
