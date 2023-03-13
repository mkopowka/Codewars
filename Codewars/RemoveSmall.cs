using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class RemoveSmall
    {
        public List<int> RemoveSmallest(List<int> numbers)
        {
            if(numbers.Count == 0)
              {
                return numbers;
            }

            int min = numbers.Min();
            int minIndex = numbers.IndexOf(min);
            return numbers.Where((val, idx) => idx != minIndex).ToList();
        }
    }
}
