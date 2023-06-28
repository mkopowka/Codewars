using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FindAverages
    {
        public double FindAverage(double[] array)
        {
            double sum = 0;
            for (int i = 0;i<array.Length;i++)
            {
                sum = sum + array[i];
            }
            sum /= array.Length;
            return sum;
  }
    }
}
