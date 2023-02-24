using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ArraysInversion
    {
        public int[] InvertValues(int[] input)
        {

            int[] result = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                result[i]= input[i]*-1;
            }
            return result;
        }
    }
}
