﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
        You will be given a list of strings. You must sort it alphabetically (case-sensitive, and based on the ASCII values of the chars) and then return the first value.
        The returned value must be a string, and have "***" between each of its letters.
        You should not remove or add elements from/to the array.
    */
    internal class TwoSort
    {
        public static string TwoSorts(string[] s)
        {   
            Array.Sort(s, StringComparer.Ordinal);
            string result = string.Join("***", s[0].ToCharArray());
            return result;
        }
    }
}
