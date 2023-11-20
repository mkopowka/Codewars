using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CalculateTips
    {
        public static int CalculateTip(double amount, string rating)
        {

            string lowerCaseRating = rating.ToLower();

            switch (lowerCaseRating)
            {
                case "terrible":
                    return (int)Math.Ceiling(amount * 0.00);
                case "poor":
                    return (int)Math.Ceiling(amount * 0.05);
                case "good":
                    return (int)Math.Ceiling(amount * 0.10);
                case "great":
                    return (int)Math.Ceiling(amount * 0.15);
                case "excellent":
                    return (int)Math.Ceiling(amount * 0.20);
                default:
                    switch (rating.ToUpper())
                    {
                        case "TERRIBLE":
                        case "POOR":
                        case "GOOD":
                        case "GREAT":
                        case "EXCELLENT":
                            return -1;
                    }
                    return -1;

            }
        }
    }
}
