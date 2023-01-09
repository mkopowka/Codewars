using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CheckIsTriange
    {
        public bool IsTriangle(int a, int b, int c)
        {

           if(a<=0 && b<=0 && c<=0)
                return false;

            if (a + b > c && a + c > b && c + b > a)
                return true;
            else
                return false;
        }
    }
}
