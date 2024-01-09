using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Count the number of occurrences of each character and return it as a (list of tuples) in order of appearance. For empty output return (an empty list).
     */

    internal class OrderCount
    {
        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            return input.GroupBy(x=>x).Select(x=>Tuple.Create(x.Key,x.Count())).ToList();
        }
    }
}
