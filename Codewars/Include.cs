using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Include
    {
        public static bool Includes(int[] arr, int item)
        {
            if (arr.Contains(item)) return true;
            else return false;
        }
    }
}
