using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class IsCubes
    {
        public bool IsCube(double volume, double side)
        {
            double expectedVolume = 0;
            if (volume <= 0 || side <= 0)
                return false;
            else
            {
                 expectedVolume = side * side * side;
            }
            return volume == expectedVolume;
        }
    }
}
