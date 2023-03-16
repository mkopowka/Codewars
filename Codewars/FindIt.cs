using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FindIt
    {
        public static int find_it(int[] seq)
        {
            foreach (int number in seq)
            {
                int count = 0;
                foreach (int num in seq)
                {
                    if (num == number)
                    {
                        count++;
                    }
                }
                if (count % 2 != 0) 
                {
                    return number;
                }
            }
            return -1;
        }
    }
}
