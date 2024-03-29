﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Basic regex tasks. Write a function that takes in a numeric code of any length. The function should check if the code begins with 1, 2, or 3 and return true if so. Return false otherwise.
     * */
    internal class ValidateCodes
    {
        public static bool ValidateCode(string code)
        {
            return Regex.IsMatch(code,"^[123]");
        }
    }
}
