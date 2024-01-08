using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class MultiplicationTables
    {
        /* Your task, is to create N×N multiplication table, of size provided in parameter.  */
        public static int[,] MultiplicationTable(int size)
        {
            int[,] table = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                }
            }

            return table;
        }
    }
}
