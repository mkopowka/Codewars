using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class HumanYearsCatYearsDogYears
    {

        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            int catYears = 0;
            int dogYears = 0;

            if (humanYears >= 1)
            {
                catYears += 15; 
                dogYears += 15; 

                if (humanYears >= 2)
                {
                    catYears += 9; 
                    dogYears += 9; 

                    for (int i = 3; i <= humanYears; i++)
                    {
                        catYears += 4; 
                        dogYears += 5; 
                    }
                }
            }

            return new int[] { humanYears, catYears, dogYears };
        }
    }
}
