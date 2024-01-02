using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Accum
    {
        public static String Accums(string s)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                result.Append(char.ToUpper(s[i]));

                for (int j = 0; j < i; j++)
                {
                    result.Append(char.ToLower(s[i]));
                }

                if (i < s.Length - 1)
                {
                    result.Append('-');
                }
            }

            return result.ToString();
        }
    }
}
