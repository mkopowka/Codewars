using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FixCase
    {
        public static string Solve(string input)
        {
            return s.Count(char.IsUpper) > s.Count(char.IsLower) ? s.ToUpper() : s.ToLower();
        }
    }
}
