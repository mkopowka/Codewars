using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CheckIsSquare
    {

        public bool IsSquare(int n)
        {
            return (Math.Sqrt(n) % 1 == 0);
        }
    }
}
