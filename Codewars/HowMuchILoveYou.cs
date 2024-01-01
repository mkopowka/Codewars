using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class HowMuchILoveYou
    {
        public static string HowMuchILoveYous(int nb_petals)
        {
            string[] phrases = { "I love you", "a little", "a lot", "passionately", "madly", "not at all" };
            int index = (nb_petals - 1) % phrases.Length;
            return phrases[index];
        }
    }
}
