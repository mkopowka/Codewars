using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Given a string of words (x), you need to return an array of the words, sorted alphabetically by the final character in each.

        If two words have the same last letter, they returned array should show them in the order they appeared in the given string.
    */
    internal class Lasts
    {
        public static string[] Last(string x)
        {
            string[] words = x.Split(' ');
            string[] sortedWords = words.OrderBy(word => word.Last()).ToArray();

            return sortedWords;
        }
    }
}
