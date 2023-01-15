using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FinalGrade
    {
        public static int FinalGrades(int exam, int projects)
        {
            int final = 0;
            if (exam > 90 || projects >= 10)
            {
                final = 100;
            }
            else if (exam > 75 && projects >= 5)
            {
                final = 90;
            }
            else if (exam > 50 && projects >= 2)
            {
                final = 75;
            }
            else
                final = 0;
            return final;
        }
    }
}
