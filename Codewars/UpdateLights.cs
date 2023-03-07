using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class UpdateLights
    {
        public static string UpdateLight(string current)
        {
            if(current=="green")
            {
                return "yellow";
            }else if(current=="yellow")
            {
                return "red";
            }else
            {
                return "green";
            }
        }
    }
}
