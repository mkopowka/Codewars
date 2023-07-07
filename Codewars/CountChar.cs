using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CountChar
    {
        public static Dictionary<char, int> CountCharacters(string input)
        {
            Dictionary<char, int> characterCounts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (characterCounts.ContainsKey(c))
                {
                    characterCounts[c]++;
                }
                else
                {
                    characterCounts[c] = 1;
                }
            }

            return characterCounts;
        }
    }
}
