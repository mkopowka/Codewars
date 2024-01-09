using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Write a simple regex to validate a username. Allowed characters are:

        lowercase letters,
        numbers,
        underscore
        Length should be between 4 and 16 characters (both included).
    */
    internal class ValidateUsr
    {
        public static bool ValidateUser(string username)
        {
            string pattern = "^[a-z0-9_]{4,16}$";
            return Regex.IsMatch(username, pattern);
        }
    }
}
