using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * You received a whatsup message from an unknown number. Could it be from that girl/boy with a foreign accent you met yesterday evening?

    Write a simple function to check if the string contains the word hallo in different languages.

    These are the languages of the possible people you met the night before:

    hello - english
    ciao - italian
    salut - french
    hallo - german
    hola - spanish
    ahoj - czech republic
    czesc - polish
    Notes

    you can assume the input is a string.
    to keep this a beginner exercise you don't need to check if the greeting is a subset of word (Hallowen can pass the test)
    function should be case insensitive to pass the tests
    */
    internal class Validate_hellos
    {
        public static bool Validate_hello(string greetings)
        {
            string lowerMessage = greetings.ToLower();
            string[] greetingz = { "hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc" };
            foreach (string greeting in greetingz)
            {
                if (lowerMessage.Contains(greeting))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
