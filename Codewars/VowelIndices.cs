using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class VowelIndices
    {
        static int[] FindVowelIndices(string word)
        {
            int vowelCount = 0;

            foreach (char letter in word)
            {
                if (IsVowel(letter))
                {
                    vowelCount++;
                }
            }

            int[] vowelIndices = new int[vowelCount];
            int currentIndex = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = Char.ToLower(word[i]);

                if (IsVowel(currentLetter))
                {
                    vowelIndices[currentIndex++] = i + 1;
                }
            }

            return vowelIndices;
        }
        static bool IsVowel(char character)
        {
            return "aeiouyAEIOUY".Contains(Char.ToLower(character));
        }
    }

}
