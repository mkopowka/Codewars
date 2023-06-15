using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ExpandedFormm
    {
        public static string ExpandedForm(int num)
        {
            string number = num.ToString();
            string expandedForm = "";

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != '0')
                {
                    int zeros = number.Length - i - 1;
                    expandedForm += number[i] + new string('0', zeros) + " + ";
                }
            }

            // Remove the trailing " + " from the expanded form
            expandedForm = expandedForm.TrimEnd(' ', '+');

            return expandedForm;
        }
    }
}
