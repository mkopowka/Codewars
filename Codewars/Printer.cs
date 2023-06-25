using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Printer
    {
        public static string PrinterError(String s)
        {
            int errorCount = 0;
            int totalLength = s.Length;

            foreach (char c in s)
            {
                if (c < 'a' || c > 'm')
                {
                    errorCount++;
                }
            }
            return $"{errorCount}/{totalLength}";
        }
    }
}
