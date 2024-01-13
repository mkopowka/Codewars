using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Your task is to write a function which returns the sum of a sequence of integers.

    The sequence is defined by 3 non-negative values: begin, end, step.

    If begin value is greater than the end, your function should return 0. If end is not the result of an integer number of steps, then don't add it to the sum. See the 4th example below.
    */
    internal class SequenceSums
    {
        public static int SequenceSum(int start, int end, int step)
        {
            int sum = 0;

            for (int i = start; i <= end; i += step)
            {
                sum += i;
            }

            return sum;
        }
    }
}
