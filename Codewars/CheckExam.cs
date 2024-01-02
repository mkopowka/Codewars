using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CheckExam
    {
        public static int CheckExams(string[] arr1, string[] arr2)
        {
            int score = 0;


            for (int i = 0; i < arr1.Length; i++)
            {

                if (arr1[i] == arr2[i])
                {

                    score += 4;
                }
                else if (string.IsNullOrWhiteSpace(arr2[i]))
                {

                    score += 0;
                }
                else
                {

                    score -= 1;
                }

            }
            if (score < 0) score = 0;
            return score;
        }
    }
}
