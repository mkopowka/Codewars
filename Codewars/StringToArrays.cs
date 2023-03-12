using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class StringToArrays
    {
        public static string[] StringToArray(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return new string[0];
            }
            else
            {
                string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return words.Length == 0 ? words : words.Select(w => w.Trim()).ToArray();
            }
        }
    }
}
