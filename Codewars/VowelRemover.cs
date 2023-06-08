using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    internal class VowelRemover
    {
        public static string Shortcut(string input)
        {
            return Regex.Replace(input, "[aeiouAEIOU]", "");
        }
    }
}
