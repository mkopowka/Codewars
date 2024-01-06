using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class AlphabetWar
    {
        public static string AlphabetWars(string fight)
        {
                Dictionary<char, int> leftSidePower = new Dictionary<char, int>
            {
                {'w', 4},
                {'p', 3},
                {'b', 2},
                {'s', 1}
            };

                Dictionary<char, int> rightSidePower = new Dictionary<char, int>
            {
                {'m', 4},
                {'q', 3},
                {'d', 2},
                {'z', 1}
            };

            int leftScore = fight.Sum(c => leftSidePower.ContainsKey(c) ? leftSidePower[c] : 0);
            int rightScore = fight.Sum(c => rightSidePower.ContainsKey(c) ? rightSidePower[c] : 0);

            if (leftScore > rightScore)
            {
                return "Left side wins!";
            }
            else if (rightScore > leftScore)
            {
                return "Right side wins!";
            }
            else
            {
                return "Let's fight again!";
            }
        }
    }
}
