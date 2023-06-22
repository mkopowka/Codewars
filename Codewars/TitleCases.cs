using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class TitleCases
    {
        public static string TitleCase(string title, string minorWords = "")
        {
            if (string.IsNullOrEmpty(title))
                return title;

            var minorWordsList = string.IsNullOrEmpty(minorWords)
                ? new string[0]
                : minorWords.ToLower().Split(' ');

            var titleWords = title.ToLower().Split(' ');

            var result = string.Join(" ", titleWords.Select((word, index) =>
            {
                if (index == 0 || !minorWordsList.Contains(word))
                {
                    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word);
                }
                else
                {
                    return word;
                }
            }));

            return result;
        }
    }
}
