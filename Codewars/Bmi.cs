using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Bmi
    { 
        public static string Bmis(double weight, double height)
        {
            double result = weight / (height * height);

            if(18.5>=result)
            {
                return "Underweight";
            } else if (25.5 >= result)
            {
                return "Normal";
            }
            else if (30 >= result)
            {
                return "Overweight";
            }else
            return "Obese";
        }
    }
}
