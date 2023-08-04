using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ShortestString
    {
        public static int FindShort(string s)
        {
            return s.Split(' ').Min(x => x.Length);
        }
    }
}
