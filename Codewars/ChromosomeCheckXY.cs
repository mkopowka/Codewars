using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ChromosomeCheckXY
    {
        public static string ChromosomeCheck(string sperm)
        {
            if (sperm.Contains("Y"))
            {
                return "Congratulations! You're going to have a son.";
            }
            else
            {
                return "Congratulations! You're going to have a daughter.";
            }
        }
    }
}
