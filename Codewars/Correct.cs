using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Correct
    {
        public static string Corrects(string text)
        {
            string corrected = "";
            foreach (char c in text)
            {
                if (c == '5')
                {
                    corrected += 'S';
                }
                else if (c == '0')
                {
                    corrected += 'O';
                }
                else if (c == '1')
                {
                    corrected += 'I';
                }
                else
                {
                    corrected += c;
                }
            }
            return corrected;
        }
    }
}
