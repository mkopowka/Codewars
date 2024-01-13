using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Remove all exclamation marks from the end of sentence.

        */
    internal class RemoveExclamationMarksSentence
    {
        public static string Remove(string s)
        {
            while (s.EndsWith('!'))
            {
                s = s.Substring(0, s.Length - 1);
            }
            return s;
        }
    }
}
