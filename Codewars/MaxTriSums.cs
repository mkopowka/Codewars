using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Task
        Given an array/list [] of n integers , find maximum triplet sum in the array Without duplications .

        Notes :
        Array/list size is at least 3 .

        Array/list numbers could be a mixture of positives , negatives and zeros .

        Repetition of numbers in the array/list could occur , So (duplications are not included when summing).
    */
    internal class MaxTriSums
    {
        public static int MaxTriSum(int[] a)
        {
            return a.Distinct().OrderByDescending(x => x).Take(3).Sum();
        }
    }
}
