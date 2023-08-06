using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ToCsvText
    {
        public static string ToCsvTexts(int[][] array)
        {
            StringBuilder csvBuilder = new StringBuilder();

            int rows = array.Length;

            for (int i = 0; i < rows; i++)
            {
                int[] row = array[i];
                int cols = row.Length;

                for (int j = 0; j < cols; j++)
                {
                    csvBuilder.Append(row[j]);

                    // Add comma for all elements except the last one in the row
                    if (j < cols - 1)
                    {
                        csvBuilder.Append(",");
                    }
                }

                // Add newline after each row except the last one
                if (i < rows - 1)
                {
                    csvBuilder.AppendLine();
                }
            }

            return csvBuilder.ToString();
        }
    }
}
