using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class DuplicateEncodes
    {
        public static string DuplicateEncode(string word)
        {
            if (string.IsNullOrEmpty(word))
                return word;

            var lowercaseWord = word.ToLower();
            var charCounts = lowercaseWord.GroupBy(c => c)
                                          .ToDictionary(g => g.Key, g => g.Count());

            var result = string.Concat(lowercaseWord.Select(c => charCounts[c] > 1 ? ')' : '('));

            return result;
        }
    }
}
