using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CountSheepz
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(s => s);
        }
    }
}
