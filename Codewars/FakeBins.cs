using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FakeBins
    {
        public static string FakeBin(string x)
        {
            string result = "";
            foreach (char c in x)
            {
                result += int.Parse(c.ToString()) < 5 ? "0" : "1";
            }
            return result;
        }
    }
}
