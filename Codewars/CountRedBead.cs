using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* Two red beads are placed between every two blue beads. There are N blue beads. After looking at the arrangement below work out the number of red beads.
     */
    internal class CountRedBead
    {
        public static int CountRedBeads(int n)
        {
            if (n < 2)
            {
                return 0;
            }
            return (n - 1) * 2;
        }
    }
}
