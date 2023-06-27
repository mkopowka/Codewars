using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class GetDrinkByProfession
    {
        public static string GetDrinkByProfessions(string p)
        {
            string lowercaseInput = p.ToLower();

            switch (lowercaseInput)
            {
                case "jabroni":
                    return "Patron Tequila";
                case "school counselor":
                    return "Anything with Alcohol";
                case "programmer":
                    return "Hipster Craft Beer";
                case "bike gang member":
                    return "Moonshine";
                case "politician":
                    return "Your tax dollars";
                case "rapper":
                    return "Cristal";
                default:
                    return "Beer";
            }
        }
    }
}
