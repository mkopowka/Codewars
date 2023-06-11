using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class PipeFix
    {
        public static List<int> PipeFixer(List<int> numbers)
        {
            List<int> result = new List<int>();
            for (int i = numbers.FirstOrDefault(); i < numbers.LastOrDefault()+1; i++) 
            {
                result.Add(i);
            }

            return result;
        }
    }
}
