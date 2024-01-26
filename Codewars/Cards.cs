using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{/* You get any card as an argument. Your task is to return the suit of this card (in lowercase). */
    internal class Cards
    {
        public static string DefineSuit(string card)
        {
            char suitSymbol = card[card.Length - 1];

            switch (suitSymbol)
            {
                case '♣':
                    return "clubs";
                case '♦':
                    return "diamonds";
                case '♥':
                    return "hearts";
                case '♠':
                    return "spades";
                default:
                    throw new ArgumentException("Invalid card: " + card);
            }
        }
    }
}
