﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CountSheepz
    {
        public static int CountSheeps(bool[] sheeps)
        {
            int count = 0;

            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i] == true)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
