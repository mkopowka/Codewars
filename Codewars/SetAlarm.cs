﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class SetAlarm
    { 
        public bool SetAlarms(bool employed, bool vacation)
        {
            if (employed && !vacation) return true;
            else return false;
        }
    }
}
