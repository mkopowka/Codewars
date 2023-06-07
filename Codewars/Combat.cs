using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Combat
    {
        public static float Combats(float health, float damage)
        {
            if(health-damage < 0) { return 0; } else return health- damage;
        }
    }
}
