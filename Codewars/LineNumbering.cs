using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class LineNumbering
    {
        public static List<string> Number(List<string> lines)
        {
            List<string> numberedLines = new List<string>();
            int lineNumber = 1;

            foreach (string line in lines)
            {
                string numberedLine = $"{lineNumber}: {line}";
                numberedLines.Add(numberedLine);
                lineNumber++;
            }

            return numberedLines;
        }
    }
}
