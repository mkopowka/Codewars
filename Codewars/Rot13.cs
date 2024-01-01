using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Rot13
    {
        public static string Rots13(string message)
        {
            char Rotate(char ch, int shift)
            {
                if (!char.IsLetter(ch))
                    return ch;

                char offset = char.IsUpper(ch) ? 'A' : 'a';
                return (char)((ch - offset + shift) % 26 + offset);
            }

            char[] resultArray = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                resultArray[i] = Rotate(message[i], 13);
            }

            return new string(resultArray);
        }
    }
}
