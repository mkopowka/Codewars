using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Write a function that removes every lone 9 that is inbetween 7s. */


    internal class SevenAt9
    {
        public static string SevenAteNine(string str)
        {
            char[] chars = str.ToCharArray();

            for (int i = 1; i < chars.Length - 1; i++)
            {
                if (chars[i - 1] == '7' && chars[i] == '9' && chars[i + 1] == '7')
                {
                    chars[i] = '7';
                }
            }

            return new string(chars).Replace("97", "");
        }
    }
}
