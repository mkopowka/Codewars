using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Codewars
{
    /*
     * If　a = 1, b = 2, c = 3 ... z = 26

        Then l + o + v + e = 54

        and f + r + i + e + n + d + s + h + i + p = 108

        So friendship is twice as strong as love :-)

        Your task is to write a function which calculates the value of a word based off the sum of the alphabet positions of its characters.

        The input will always be made of only lowercase letters and will never be empty.
    */
    internal class WordsToMark
    {
        public static int WordsToMarks(string str)
        {
            char[] character = str.ToCharArray();
            int result = 0;
            for (int i = 0; i < character.Length; i++)
            {
                int value = Char.ToUpper(character[i]) - 'A' + 1;
                result += value;

            }
            return result;
        }
    }
}
