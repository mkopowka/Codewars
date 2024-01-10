using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SortMyStrings
    {
        /* Given a string s. You have to return another string such that even-indexed and odd-indexed characters of s are grouped and groups are space-separated (see sample below) */
        public string SortMyString(string s)
        {

            string odd ="";
            string even = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even += s[i];
                }
                else
                {
                    odd += s[i];
                }
            }
            return even + " " + odd ;
        }
    }
}
