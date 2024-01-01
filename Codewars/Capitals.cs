using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Capitals
    {
        public static int[] Capitalz(string word)
        {
            return Regex.Matches(word, "[A-Z]").Select(m => m.Index).ToArray();

        }
    }
}
