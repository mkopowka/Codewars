using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FindIt
    {
        public static int find_it(int[] seq)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < seq.Length; i++)
            {
                if (dictionary.ContainsKey(seq[i]))
                {
                    dictionary[seq[i]]++;
                }
                else
                {
                    dictionary[seq[i]] = 1;
                }
            }
            foreach (var item in dictionary)
            {
                if (item.Value % 2 != 0)
                {
                    return item.Key;
                }
            }
            return -1;
        }
    }
}
