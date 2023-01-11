using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class СenturyFromYearz
    {
        public static int СenturyFromYear(int year)
        {
            int century = year / 100;
            year %= 100;
            if (year > 0)
            {
                century += 1;
            }
            return century;
        }
    }
}
