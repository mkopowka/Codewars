using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class AreYouPlayingBanjo
    {
        public static string AreYouPlayingBanjos(string name)
        {
            if (name.StartsWith('r') || name.StartsWith('R'))
            {
                return name + " plays banjo";
            }
            else
                return name + " does not play banjo";
        }
    }
}
