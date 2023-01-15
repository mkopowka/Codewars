using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class GetSum
    {
        public int GetSums(int a, int b)
        {
            int result = 0;
            if (a < b)
                if (a < b)
                {

                    for (int i = a; i < b + 1; i++)
                    {
                        result += i;
                    }
                }
                else if (a > b)
                {
                    for (int i = b; i < a + 1; i++)
                    {
                        result += i;
                    }
                }
            return result;
        }
    }
}
