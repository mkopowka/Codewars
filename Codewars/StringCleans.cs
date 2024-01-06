using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    internal class StringCleans
    {
        /*Your boss decided to save money by purchasing some cut-rate optical character recognition software for scanning in the text of old novels to your database. 
         * At first it seems to capture words okay, but you quickly notice that it throws in a lot of numbers at random places in the text.
         **/
        public static string StringClean(string s)
        {
            return Regex.Replace(s, @"\d+", "");
        }
    }
}
