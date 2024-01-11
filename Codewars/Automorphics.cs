using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Automorphics
    {
        /* A number is called Automorphic number if and only if its square ends in the same digits as the number itself. */
        public static string Automorphic(int n)
        {
            int square = n * n;
            string number = n.ToString();
            string squareStr = square.ToString();

            if (squareStr.EndsWith(number))
            {
                return "Automorphic";
            }
            else
                return "No!!";


        }
    }
}
