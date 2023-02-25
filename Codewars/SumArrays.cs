using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SumArrays
    {
        public static double SumArray(double[] array)
        {
            double sum = 0;
            if(array==null) return 0;
            else
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
         }
    }
}
