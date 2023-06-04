using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class IsIsogram
    {
        public static bool Isogram(string str)
        {
            str = str.ToLower();

            HashSet<char> charSet = new HashSet<char>();

            foreach (char c in str)
            {
                // If the character is a letter and already in the set, it's a repeating letter
                if (char.IsLetter(c) && !charSet.Add(c))
                    return false;
            }

            return true;

        }
    }
}
