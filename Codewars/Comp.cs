using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Comp
    {
        public static bool Comps(int[] a, int[] b)
        {
            if (a == null || b == null || a.Length != b.Length)
                return false;

            var freqA = new Dictionary<int, int>();
            var freqB = new Dictionary<int, int>();

            foreach (int num in a)
            {
                if (freqA.ContainsKey(num))
                    freqA[num]++;
                else
                    freqA[num] = 1;
            }

            foreach (int num in b)
            {
                if (freqB.ContainsKey(num))
                    freqB[num]++;
                else
                    freqB[num] = 1;
            }

            foreach (var kvp in freqA)
            {
                int num = kvp.Key;
                int freqInA = kvp.Value;

                if (!freqB.ContainsKey(num * num) || freqB[num * num] != freqInA)
                    return false;
            }


            return true;
        }
    }
}
