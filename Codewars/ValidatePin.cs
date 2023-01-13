using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ValidatePin
    {
        public bool ValidatePinz(string pin)
        {
            int parse = 0;
            if (pin.Length == 4 || pin.Length == 6)
            return int.TryParse(pin,out parse);
                else
            return false;
        }
    }
}
