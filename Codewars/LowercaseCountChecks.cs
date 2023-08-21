using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class LowercaseCountChecks
    {
        public static int LowercaseCountCheck(string s)
        {
            int countLower = 0;
            foreach (char c in s)
            {
                if(char.IsLower(c))
                {
                    countLower++;
                }
            }
            return countLower;
        }
    }
}
