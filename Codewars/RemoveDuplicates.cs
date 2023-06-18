using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class RemoveDuplicates
    {
        public static int[] distinct(int[] a)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();
            List<int> result = new List<int>();

            foreach (int number in a)
            {
                if (uniqueNumbers.Add(number))
                {
                    result.Add(number);
                }
            }

            return result.ToArray();
        }
    }
}
