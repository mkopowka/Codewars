using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Complete the method which returns the number which is most frequent in the given input array. If there is a tie for most frequent number, return the largest number among them. */
    internal class HighestRanks
    {
        public static int HighestRank(int[] arr)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            int mostFrequentNumber = frequencyMap.Keys
                .OrderByDescending(key => frequencyMap[key])
                .ThenByDescending(key => key)
                .First();

            return mostFrequentNumber;
        }
    }
}
