using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * My grandfather always predicted how old people would get, and right before he passed away he revealed his secret!

        In honor of my grandfather's memory we will write a function using his formula!

        Take a list of ages when each of your great-grandparent died.
        Multiply each number by itself.
        Add them all together.
        Take the square root of the result.
        Divide by two.
    */
    internal class PredictAges
    {
        public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8)
        {
            int[] ages = { age1, age2, age3, age4, age5, age6, age7, age8 };

            double sumOfSquaredAges = 0;

            foreach (int age in ages)
            {
                sumOfSquaredAges += age * age;
            }

            double squareRoot = Math.Sqrt(sumOfSquaredAges);
            int predictedAge = (int)(squareRoot / 2);

            return predictedAge;
        }
    }
}
