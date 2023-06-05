using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class AbbrevNames
    {
        public static string AbbrevName(string name)
        {
            string[] words = name.Split(' ');


            char firstInitial = char.ToUpper(words[0][0]);
            char secondInitial = char.ToUpper(words[1][0]);

            string initials = $"{firstInitial}.{secondInitial}";

            return initials;
        }
    }
}
