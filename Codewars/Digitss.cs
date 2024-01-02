using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Digitss
    {
        public static int Digits(ulong n)
        {
            string value = n.ToString();
            int counter = 0;
            foreach (char c in value)
            {
                counter++;
            }
            return counter;
        }
    }
}
