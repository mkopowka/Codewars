using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SwapFirstNameLastName
    {
        public static string NameShuffler(string str)
        {
            string[] nameParts = str.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];
            string swappedName = $"{lastName} {firstName}";

            return swappedName;
        }
    }
}
