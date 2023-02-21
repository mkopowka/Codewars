using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class IsAnagram1
    {
        public bool IsAnagram(string test, string original)
        {
            char[] ch1 = test.ToLower().ToCharArray();
            char[] ch2 = original.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string v1 = new string(ch1);
            string v2 = new string(ch2);

            if(v1==v2)
            {
                return true;
            }else

            return false;
        }
    }
}
