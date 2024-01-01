using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class AlphabetPosition
    {
        public static string Alphabetposition(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    int position = char.ToUpper(c) - 'A' + 1;
                    result.Append(position + " ");
                }
            }

            return result.ToString().Trim();
        }
    }
}
