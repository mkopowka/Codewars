using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Given a list and a number, create a new list that contains each number of list at most N times, without reordering.
        For example if the input number is 2, and the input list is [1,2,3,1,2,1,2,3], you take [1,2,3,1,2], drop the next [1,2] since this would lead to 1 and 2 being in the result 3 times, and then take 3, which leads to [1,2,3,1,2,3].
        With list [20,37,20,21] and number 1, the result would be [20,37,21].
    */
    internal class DeleteNths
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            List<int> resultList = new List<int>();
            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (!occurrences.ContainsKey(num) || occurrences[num] < x)
                {
                    resultList.Add(num);

                    if (occurrences.ContainsKey(num))
                    {
                        occurrences[num]++;
                    }
                    else
                    {
                        occurrences[num] = 1;
                    }
                }
            }

            return resultList.ToArray();
        }
    }
}
