using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Summation
    {
        public int summation(int num)
        {
            int result = 0;
            for (int i=1;i<num+1;i++)
            {
                result+= i;
            }

            return result;
    }
    }
}
