using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Define a method/function that removes from a given array of integers all the values contained in a second array.

 */
    internal class RemoveMarked
    {
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            return integerList.Where(x => !valuesList.Contains(x)).ToArray();
        }
    }
}
