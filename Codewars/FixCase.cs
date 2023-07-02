using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FixCase
    {
        public static string Solve(string input)
        {
            int uppercaseCount = 0;
            int lowercaseCount = 0;

            // Count the number of uppercase and lowercase letters
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    uppercaseCount++;
                }
                else if (char.IsLower(c))
                {
                    lowercaseCount++;
                }
            }

            // Convert the string based on the conditions
            if (uppercaseCount > lowercaseCount)
            {
                return input.ToUpper();
            }
            else
            {
                return input.ToLower();
            }
        }
    }
}
