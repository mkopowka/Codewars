using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * In this first kata in the series, you need to define a Hero class to be used in a terminal game. The hero should have the following attributes:

        attribute	type	value
        Name	string	user argument or "Hero"
        Position	string	"00"
        Health	float	100
        Damage	float	5
        Experience	int	0
    */
    public class Hero
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public float Health { get; set; }
        public float Damage { get; set; }
        public int Experience { get; set; }

        public Hero(string name="Hero")
        {
            Name = name;
            Position = "00";
            Health = 100;
            Damage = 5;
            Experience = 0;
        }
    }
}
