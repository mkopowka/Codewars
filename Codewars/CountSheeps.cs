using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CountSheeps
    {
        public static string CountSheep(int n)
        {
            string result = "";
            for(int i = 1; i <= n; i++)
            {
                result += i.ToString() + " sheep...";
            }

            return result;
        }
    }
}
