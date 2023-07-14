using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class DnaToRna
    {
        public string dnaToRna(string dna)
        {
            string rna = "";

            foreach (char nucleotide in dna)
            {
                if (nucleotide == 'T')
                {
                    rna += 'U';
                }
                else
                {
                    rna += nucleotide;
                }
            }

            return rna;
        }
    }
}
