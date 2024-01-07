using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Codewars
{
    internal class AddLengths
    {
        /*
         * What if we need the length of the words separated by a space to be added at the end of that same word and have it returned as an array?

            Example(Input --> Output)

            "apple ban" --> ["apple 5", "ban 3"]
            "you will win" -->["you 3", "will 4", "win 3"]
            Your task is to write a function that takes a String and returns an Array/list with the length of each word added to each element .
        */
        public string[] AddLength(string str)
        {
            string[] wyrazy = str.Split(' ');
            string[] stri = new string[wyrazy.Length];
            int i = 0;
            foreach (string s in wyrazy)
            {
                stri[i] = $"{s} {s.Length}";
                i++;
            }
            Console.WriteLine(stri);
            return stri;
        }
    }
}
