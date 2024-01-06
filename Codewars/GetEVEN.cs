using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Starting with .NET Framework 3.5, C# supports a Where (in the System.Linq namespace) method which allows a user to filter arrays based on a predicate. Use the Where method to complete the function given.

        Enumerable.Where documentation: https://msdn.microsoft.com/en-us/library/bb534803(v=vs.110).aspx

        The solution would work like the following:
    */
    internal class GetEven
    {
        public static int[] GetEvenNumbers(int[] numbers)
        {
            return numbers.Where(numbers => numbers %2 == 0).ToArray();
        }
    }
}
