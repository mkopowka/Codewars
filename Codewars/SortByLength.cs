using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SortByLength
    {
        public static string[] SortByLengths(string[] array)
        {
            return array.OrderBy(e => e.Length).ToArray();
        }
    }
}
