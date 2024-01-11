﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Ifs
    {
        /*
         * Create a function called _if which takes 3 arguments: a value bool and 2 functions (which do not take any parameters): func1 and func2

        When bool is truthy, func1 should be called, otherwise call the func2.
        */
        public static void If(bool condition, Action func1, Action func2)
        {

            if (condition) { func1(); }
            else func2();
        }
    }
}
