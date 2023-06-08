using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class PeopleDrink
    {
        public static string PeopleWithAgeDrink(int old)
        {
            if (old < 14) { return "drink toddy"; }
            else if (old >= 14 && old < 18) { return "drink coke"; }
            else if (old >= 18 && old < 21) { return "drink beer"; }
            else return "drink whisky";
        }
    }
}
