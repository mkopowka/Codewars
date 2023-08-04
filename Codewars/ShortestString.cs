using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ShortestString
    {
        public static int FindShort(string s)
        {
            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            int shortestLength = words[0].Length;

            for (int i = 1; i < words.Length; i++)
            {
                int wordLength = words[i].Length;
                if (wordLength < shortestLength)
                {
                    shortestLength = wordLength;
                }
            }

            return shortestLength;
        }
    }
}
