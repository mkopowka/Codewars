using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Balls
    {
        public string ballType { get; set; }
  
    public Balls(string ballType = "regular")
    {
        this.ballType = ballType;
    }

    // Method to get the ball type
    public string GetBallType()
    {
        return ballType;
    }
    }
}
