using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class NoOdd
    {
        public static int[] NoOdds(int[] values)
        {
            List<int> result = new List<int>(); 
           foreach (int value in values)
            {
                if(value % 2 ==0)
                {
                    result.Add(value);
                }
            }
            return result.ToArray();
        }
    }
}
