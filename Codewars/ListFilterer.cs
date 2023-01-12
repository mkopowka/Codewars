using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ListFilterer
    {
        public IEnumerable<int> GetIntegersFromList(List<object> listOfItems)

        {
            return  listOfItems.OfType<int>().ToList();
        }
    }
}
