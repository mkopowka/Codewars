using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CountDuplicates
    {
        public static int DuplicateCount(string str)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            int repeatedCount = 0;

            foreach (char c in str.ToLower())
            {
                if (char.IsLetterOrDigit(c))
                {
                    if (charCounts.ContainsKey(c))
                    {
                        charCounts[c]++;
                        if (charCounts[c] == 2) // Count only characters that occur more than once
                        {
                            repeatedCount++;
                        }
                    }
                    else
                    {
                        charCounts[c] = 1;
                    }
                }
            }

            return repeatedCount;
        }
    }
}
