using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class MexicanaWave
    {
        public List<string> wave(string str)
        {
            List<string> waveList = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsWhiteSpace(str[i]))
                    continue;

                string wave = str.Substring(0, i) + char.ToUpper(str[i]) + str.Substring(i + 1);
                waveList.Add(wave);
            }

            return waveList;
        }
    }
}
