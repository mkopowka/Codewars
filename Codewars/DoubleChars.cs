using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class DoubleChars
    {
        public static string DoubleChar(string s)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in s)
            {
                result.Append(c);
                result.Append(c);
            }

            return result.ToString();
        }
    }
}
