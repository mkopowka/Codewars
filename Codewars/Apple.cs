using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Apple
    {
        public static string Applez(object n)
        {
            if (int.TryParse(n.ToString(), out int intValue))
            {
                if (intValue * intValue > 1000) return "It's hotter than the sun!!";
            }
            return "Help yourself to a honeycomb Yorkie for the glovebox.";
        }
    }
}
