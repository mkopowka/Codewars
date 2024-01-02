using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    internal class StringToArrays
    {
        public static string[] StringToArray(string str)
        {
            string[] words = Regex.Split(str, @"\W+");


            words = words.Where(s => !string.IsNullOrEmpty(s)).ToArray();

            return words;
        }
    }
}
