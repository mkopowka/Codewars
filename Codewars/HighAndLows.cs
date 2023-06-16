using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class HighAndLows
    {
        public static string GetMaxAndMin(string numbersString)
        {
            string[] numberStrings = numbersString.Split(' ');

            int[] numbers = numberStrings.Select(int.Parse).ToArray();

            int max = numbers.Max();
            int min = numbers.Min();

            return $"{max} {min}";
        }
    }
}
