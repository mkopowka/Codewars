using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CountPositiveSumNegative
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0)
            {

                return new int[0];
            }

            int countPositives = 0;
            int sumNegatives = 0;

            foreach (int num in input)
            {
                if (num > 0)
                {
                    countPositives++;
                }
                else if (num < 0)
                {
                    sumNegatives += num;
                }
            }


            return new int[] { countPositives, sumNegatives };
        }
    }
}
