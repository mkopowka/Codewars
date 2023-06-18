using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CuponCode
    {
        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
            if(enteredCode!=correctCode) { return false; }

            DateTime parsedCurrentDate, parsedExpirationDate;

            if (!DateTime.TryParse(currentDate, out parsedCurrentDate) || !DateTime.TryParse(expirationDate, out parsedExpirationDate))
            {
                Console.WriteLine("Invalid date format.");
                return false;
            }

            parsedExpirationDate = parsedExpirationDate.AddDays(1).Date;

            if (parsedCurrentDate <= parsedExpirationDate)
            {
                Console.WriteLine("Coupon is valid!");
                return true;
            }
            else
            {
                Console.WriteLine("Coupon has expired.");
                return false;
            }
        }
    }
}
