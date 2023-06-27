using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal static class IsUpperCases
    {
        public static bool IsUpperCase(this string text)
        {
            return text.Equals(text.ToUpper());
        }
    }
}
