using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Meetings
    {
        public static string Meeting(string s)
        {
            string[] guests = s.ToUpper().Split(';');
            var sortedGuests = guests.Select(g => g.Split(':')).OrderBy(g => g[1]).ThenBy(g => g[0]);

            string result = "";
            foreach (var guest in sortedGuests)
            {
                result += $"({guest[1]}, {guest[0]})";
            }

            return result;
        }
    }
}
