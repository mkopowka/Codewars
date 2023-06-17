using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ReplaceWithAlphabetPositions
    {
        public static string AlphabetPosition(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char uppercaseChar = char.ToUpper(c);
                    int position = uppercaseChar - 'A' + 1;
                    result.Append(position);
                    result.Append(" ");
                }
            }

            if (result.Length > 0)
            {
                // Remove the trailing space
                result.Length--;
            }

            return result.ToString();
        }
    }
}
