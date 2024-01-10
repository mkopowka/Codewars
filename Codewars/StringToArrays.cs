using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    /* Write a function to split a string and convert it into an array of words. */
    internal class StringToArrays
    {
        public static string[] StringToArray(string str)
        {
            string[] wordsArray = str.Split(' ');

            return wordsArray;
        }
    }
}
