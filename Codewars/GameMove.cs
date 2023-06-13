using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class GameMove
    {
        public static int Move(int position, int roll)
        {
            return position + (roll * 2);
        }
    }
}
