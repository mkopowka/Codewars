using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * When provided with a letter, return its position in the alphabet.

        Input :: "a"

        Ouput :: "Position of alphabet: 1"
    */
    internal class Positions
    {
        public static string Position(char alphabet)
        {
            alphabet = char.ToUpper(alphabet);
            int position = alphabet - 'A' + 1;

            return "Position of alphabet: " + position.ToString();
        }
    }
}
