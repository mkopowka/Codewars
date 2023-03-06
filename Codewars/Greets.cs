using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Greets
    {
        public static string Greet(string name, string owner)
        {

            if (name == owner)
            {
                return "Hello boss";
            }
            else

                return "Hello guest";
        }
    }
}
