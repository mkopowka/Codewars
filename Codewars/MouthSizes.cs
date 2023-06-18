using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class MouthSizes
    {
        public static string MouthSize(string animal)
        {
            if (animal.ToLower() == "alligator") return "small";
            else return "wide";
        }
    }
}
