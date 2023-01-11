using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class GetAge
    {
        public  int GetAges(string inputString)
        {
            int age = int.Parse(inputString[0].ToString());

            return age;
        }
    }
}
