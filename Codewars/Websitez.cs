using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* This is an easy twist to the example kata (provided by Codewars when learning how to create your own kata).

    Add the value "codewars" to the array websites 1,000 times.
    */
    public class Websitez
    {
        public static string[] Websites = Enumerable.Repeat("codewars",1000).ToArray();


    }
}
