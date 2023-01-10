using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class BreakCamelCase
    {
        public static string BreakCamelCases(string str)
        {
            string words = "";
            foreach (char ch in str)
            {
                if (char.IsLower(ch))
                {
                    words += ch.ToString();
                }
                else
                {
                    words += " " + ch.ToString();
                }

            }
            return words;
        }
    }
}
