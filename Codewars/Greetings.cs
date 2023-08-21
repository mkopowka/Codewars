using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Greetings
    {
        public static string Greet(string name)
        {
            string lowercaseRest = name.Substring(1).ToLower();
            char firstChar = char.ToUpper(name[0]);

            string names = firstChar + lowercaseRest;
            return "Hello " + names+"!";
        }
    }
}
