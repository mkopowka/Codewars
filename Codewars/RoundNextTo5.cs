using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class RoundNextTo5
    {
        public static int RoundToNextMultipleOf5(int num)
        {
            return (num + 4) / 5 * 5;
        }
    }
}
