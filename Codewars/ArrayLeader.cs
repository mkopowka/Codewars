using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*Definition
        An element is leader if it is greater than The Sum all the elements to its right side.

        Task
        Given an array/list [] of integers , Find all the LEADERS in the array.
    */
    internal class ArrayLeader
    {
        public static int[] ArrayLeaders(int[] numbers)
        {
            List<int> leaders = new List<int>();
            int n = numbers.Length;
            int maxRight = numbers[n - 1];
            leaders.Add(maxRight);

            for (int i = n - 2; i >= 0; i--)
            {
                if (numbers[i] > maxRight)
                {
                    maxRight = numbers[i];
                    leaders.Insert(0, maxRight);
                }
            }

            return leaders.ToArray();
        }
    }
}
