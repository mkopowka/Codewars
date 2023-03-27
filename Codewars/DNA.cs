using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class DNA
    {
        public static string DnaStrand(string dna)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in dna)
            {
                if (c == 'A')
                {
                    sb.Append('T');
                }
                else if (c == 'T')
                {
                    sb.Append('A');
                }
                else if (c == 'C')
                {
                    sb.Append('G');
                }
                else if (c == 'G')
                {
                    sb.Append('C');
                }
            }
            return sb.ToString();
        }
    }
}
