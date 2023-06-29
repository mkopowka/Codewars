using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SayHello
    {
        public static string SayHellos(string[] name, string city, string state)
        {
            string fullName = string.Join(" ", name);
            string greeting = $"Hello, {fullName}! Welcome to {city}, {state}!";

            return greeting;
        }
    }
}
