using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Capitalize
    {

        public static string[] Capitalizes(string s)
        {
            string[] result = new string[2];
            char[] characters = s.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (i % 2 == 0)
                {
                    // Capitalize letters at even indexes
                    result[0] += char.ToUpper(characters[i]);
                    result[1] += char.ToLower(characters[i]);
                }
                else
                {
                    // Capitalize letters at odd indexes
                    result[0] += char.ToLower(characters[i]);
                    result[1] += char.ToUpper(characters[i]);
                }
            }

            return result;
        }
    }
}
