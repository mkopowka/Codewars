using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Have you heard about the myth that if you fold a paper enough times, you can reach the moon with it? Sure you have, but exactly how many? Maybe it's time to write a program to figure it out.

    You know that a piece of paper has a thickness of 0.0001m. Given distance in units of meters, calculate how many times you have to fold the paper to make the paper reach this distance.
    (If you're not familiar with the concept of folding a paper: Each fold doubles its total thickness.)
    */
    internal class Folds
    {
        public static int? FoldTo(double distance)
        {
            if (distance < 0)
            {
                return null;
            }

            double paperThickness = 0.0001;
            int folds = 0;

            while (paperThickness < distance)
            {
                paperThickness *= 2;
                folds++;
            }

            return folds;
        }
    }
}
