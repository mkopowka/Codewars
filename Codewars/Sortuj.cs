using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Just a simple sorting usage. Create a function that returns the elements of the input-array / list sorted in lexicographical order. */
    internal class Sortuj
    {
        public static string[] SortMe(string[] names)
        {
            Array.Sort(names);
            return names;
        }
    }
}
