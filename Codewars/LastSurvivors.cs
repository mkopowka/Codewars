using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* You are given a string of letters and an array of numbers.
        The numbers indicate positions of letters that must be removed, in order, starting from the beginning of the array.
        After each removal the size of the string decreases (there is no empty space).
        Return the only letter left.
    */
    internal class LastSurvivors
    {
        public static string LastSurvivor(string letters, int[] coords)
        {
            List<char> charList = new List<char>(letters.ToCharArray());

            foreach (int coord in coords)
            {
                charList.RemoveAt(coord);
            }

            return new string(charList.ToArray());
        }
    }
}
