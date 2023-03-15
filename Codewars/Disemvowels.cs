using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Disemvowels
    {
        public static string Disemvowel(string str)
        {
            string vowels = "aeiouAEIOU";
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
