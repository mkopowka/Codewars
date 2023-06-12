using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ReverseList
    {
        public static List<int> ReverseLists(List<int> list)
        {
            List<int> reversedList = Enumerable.Reverse(list).ToList();
            return reversedList;
        }
    }
}
