using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ToCsvText
    {
        public static string ToCsvTexts(int[][] array)
        {
            return string.Join("\n", array.Select(x => string.Join(",", x)));
        }
    }
}
