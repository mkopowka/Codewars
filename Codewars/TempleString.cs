using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Template Strings, this kata is mainly aimed at the new JS ES6 Update introducing Template Strings
        Task
        Your task is to return the correct string using the Template String Feature.
        Input
        Two Strings, no validation is needed.
        Output
        You must output a string containing the two strings with the word ```' are '```
    */
    internal class TempleString
    {
        public static string TempleStrings(string obj, string feature)
        {
            return obj + " are " + feature;
        }
    }
}
