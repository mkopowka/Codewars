using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class GetUniques
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            // Count the occurrences of each number
            foreach (int num in numbers)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }

            // Find the number with count 1
            foreach (KeyValuePair<int, int> pair in countMap)
            {
                if (pair.Value == 1)
                    return pair.Key;
            }

            return -1;
        }
    }
}
