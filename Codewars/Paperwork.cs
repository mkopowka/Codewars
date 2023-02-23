using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Paperwork
    {
        public int Paperworks(int n, int m)
        {
            if (n > 0 && m > 0)
            {
                return n * m;
            }
            else
                return 0;
        }
    }
}
