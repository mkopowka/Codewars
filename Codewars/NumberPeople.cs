using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class NumberPeople
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int count = 0;
            foreach (int[] stop in peopleListInOut)
            {
                count += stop[0];  // add people who get on the bus
                count -= stop[1];  // subtract people who get off the bus
            }
            return Math.Max(count, 0);
        }
    }
}
