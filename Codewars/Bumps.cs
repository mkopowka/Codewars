using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Bumps
    {
        public static string Bump(string input)
        {
            int count = 0;
            foreach (char c in input) { 
            
                if(c=='n')
                {
                    count++;
                }
            }
            if (count <= 15)
            {
                return "Woohoo!";
            }
            else return "Car Dead";
        }
    }
}
