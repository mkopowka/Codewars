using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class GetVowelCount
    {
        public static int GetVowelCountz(string str)
        {
            int vowelCount = 0;

            char[] chars = str.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a' || chars[i] == 'e' || chars[i] == 'i' || chars[i] == 'o' || chars[i] == 'u')
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}
