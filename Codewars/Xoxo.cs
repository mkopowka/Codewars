using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Xoxo
    {
        public bool XO(string input)
        {
            char[] characters = input.ToLower().ToCharArray();
            int x = 0; int o = 0;


            for (int i = 0; i < input.Length; i++)
            {
                if (characters[i] == 'x')
                {
                    x += 1;
                }
                else
                    o += 1;
            }
            if (x == o)
            {
                return true;
            }
            else if (x > o || x < o)
            {
                return false;
            }
            else
                return true;

        }
    }
}
