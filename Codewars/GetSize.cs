using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class GetSize
    {
        public static int[] Getsize(int w, int h, int d)
        {
            int surfaceArea = (2 * (w * h)) + (2 * (w * d)) + (2 * (h * d));
            int volume = w * h * d;

            return new int[] { surfaceArea, volume };
        }
    }
}
