using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SumOfMinimum
    {
        public static int SumOfMinimums(int[,] numbers)
        {
            int sum = 0;
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < columns; j++)
                {
                    if (numbers[i, j] < min)
                    {
                        min = numbers[i, j];
                    }
                }
                sum += min;
            }

            return sum;
        }
    }
}
