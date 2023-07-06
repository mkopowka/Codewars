using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Weights
    {
        public static int[] RowWeights(int[] a)
        {
            int team1 = 0;
            int team2 = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                    team1 += a[i];
                else
                    team2 += a[i];
            }

            return new int[] { team1, team2 };
        }
    }
}
