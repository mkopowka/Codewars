using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class BalanceIndex
    {
        public static int FindEvenIndex(int[] arr)
        {
         int leftSum = 0;
        int rightSum = 0;

        // Calculate the sum of all elements in the array
        for (int i = 0; i < arr.Length; i++)
        {
            rightSum += arr[i];
        }

        // Iterate through the array and find the balance index
        for (int i = 0; i < arr.Length; i++)
        {
            // Update the right sum by subtracting the current element
            rightSum -= arr[i];

            // If the left sum is equal to the right sum, return the current index
            if (leftSum == rightSum)
            {
                return i;
            }

            // Update the left sum by adding the current element
            leftSum += arr[i];
        }

        // No balance index found, return -1
        return -1;
        }
    }
}
