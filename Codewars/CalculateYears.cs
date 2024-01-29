using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CalculateYears
    {
        public static int CalculateYearz(double principal, double interest, double tax, double desiredPrincipal)
        {
            int years = 0;

            while (principal < desiredPrincipal)
            {
                double interestEarned = principal * interest;
                double taxPaid = interestEarned * tax;
                principal += interestEarned - taxPaid;
                years++;
            }

            return years;
        }
    }
}
