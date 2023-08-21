using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SameCase
    {
        public int SameCases(char a, char b)
        {
            if (!char.IsLetter(a) || !char.IsLetter(b)) return -1; 
            if ((char.IsLower(a)) && (char.IsLower(b)) || (char.IsUpper(a)) && (char.IsUpper(b))) return 1;
            else return 0;
        }
    }
}
