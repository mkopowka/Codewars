using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Towers
    {
        public static string[] TowerBuilder(int nFloors)
        {
            List<string> tower = new List<string>();

            int width = 2 * nFloors - 1;
            for (int i = 0; i < nFloors; i++)
            {
                int numStars = 2 * i + 1;
                int numSpaces = (width - numStars) / 2;

                string floor = new string(' ', numSpaces) + new string('*', numStars) + new string(' ', numSpaces);
                tower.Add(floor);
            }

            return tower.ToArray();
        }
    }
}
