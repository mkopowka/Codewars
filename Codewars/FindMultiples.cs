using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FindMultiples
    {
        public List<int> FindMultiple(int integer, int limit)
        {
            List<int> values = new List<int>();
            for(int i=integer;i<=limit;i+=integer)
            {
                values.Add(i);
            }
            return values;
        }
    }
}
