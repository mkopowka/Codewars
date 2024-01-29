using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* The aim of this kata is to split a given string into different strings of equal size (note size of strings is passed to the method) */
    internal class SplitInPartz
    {
        public static string SplitInParts(string s, int partLength)
        {

            for (int i = partLength; i < s.Length; i += partLength + 1)
                s = s.Insert(i, " ");
            return s;
        }
    }
}
