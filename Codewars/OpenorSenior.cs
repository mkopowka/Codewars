using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class OpenorSenior
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            List<string> categories = new List<string>();

            foreach (int[] member in data)
            {
                int age = member[0];
                int handicap = member[1];

                if (age >= 55 && handicap > 7 && handicap <= 26)
                {
                    categories.Add("Senior");
                }
                else
                {
                    categories.Add("Open");
                }
            }

            return categories;
        }
    }
}
