using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Given a string of arbitrary length with any ascii characters. Write a function to determine whether the string contains the whole word "English".

    The order of characters is important -- a string "abcEnglishdef" is correct but "abcnEglishsef" is not correct.

    Upper or lower case letter does not matter -- "eNglisH" is also correct.

    Return value as boolean values, true for the string to contains "English", false for it does not.
    */
    internal class SpeakEnglishs
    {
        public static bool SpeakEnglish(string sentence)
        {
            string words = sentence.ToLower();
            string english = "english";

            if(words.Contains(english)) { return true; }else 

            return false;
        }
    }
}
