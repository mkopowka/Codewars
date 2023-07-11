using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Arra
    {
        public static string? Arrayse(string s)
        {

            if (string.IsNullOrEmpty(s))
                return null;

            string[] sequences = s.Split(',');

            if (sequences.Length <= 2)
                return null;

            return string.Join(" ", sequences[1..^1]);
        }
    }
}
