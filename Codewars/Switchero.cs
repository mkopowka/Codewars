using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Switchero
    {
        public static string Switcheroo(string x)
        {

            char[] input = x.ToCharArray();

            for (int i = 0;i<x.Length;i++)
            {
                if (input[i] =='a')
                {
                    input[i] = 'b';
                }else if (input[i] == 'b')
                {
                    input[i] = 'a';
                }
            }
            return new string(input.ToArray());
        }
    }
}
