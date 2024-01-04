using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class HelloTypo
    {
        /*
         * Define a method hello that returns "Hello, Name!" to a given name, or says Hello, World! if name is not given (or passed as an empty String).

            Assuming that name is a String and it checks for user typos to return a name with a first capital letter (Xxxx).
        */
        public static string Hello(string name="")
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                return "Hello, World!";
            }
            string formattedName = char.ToUpper(name[0]) + name.Substring(1).ToLower();

            return $"Hello, {formattedName}!";
        }
    }
}
