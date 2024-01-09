using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Write a function called sortGiftCode/sort_gift_code/SortGiftCode that accepts a string containing up to 26 unique alphabetical characters, and returns a string containing the same characters in alphabetical order.
     * */
    internal class SortGiftCodes
    {
        public string SortGiftCode(string code)
        {
           List<char> codes = new List<char>();

            foreach (var item in code)
            {
                codes.Add(item);
            }

            codes.Sort();
            string result = new string(codes.ToArray());
            return result;
        }
    }
}
