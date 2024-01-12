using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* The objective of Duck, duck, goose is to walk in a circle, tapping on each player's head until one is chosen. */
    internal class DuckDuckGooses
    {
        public static string DuckDuckGoose(Player[] players, int goose)
        {
            int adjustedIndex = (goose - 1) % players.Length;
            return players[adjustedIndex].Name;
        }
    }
    public class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }
    }
}
