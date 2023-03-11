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
            if (pin.Length != 4 && pin.Length != 6)
                return false;

            foreach (char c in pin) 
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }
    }
}
