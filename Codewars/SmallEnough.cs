using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SmallEnough
    {
        public bool SmallEnoughs(int[] a, int limit)
        {

            foreach (int value in a)
            {
                if (value > limit)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
