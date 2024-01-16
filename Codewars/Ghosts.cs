using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* 
     * Create a class Ghost

    Ghost objects are instantiated without any arguments.

    Ghost objects are given a random color attribute of "white" or "yellow" or "purple" or "red" when instantiated
    */
    internal class Ghosts
    {
        public string GetColor()
        {
            string[] possibleColors = { "white", "yellow", "purple", "red" };
            Random random = new Random();
            string colorz = possibleColors[random.Next(possibleColors.Length)];
            return colorz;
        }
    }
}
