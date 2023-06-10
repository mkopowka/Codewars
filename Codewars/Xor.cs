using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Xor
    {
        public static bool Xors(bool a, bool b)
        {
            return (a && !b) || (!a && b);
        }
    }
}
