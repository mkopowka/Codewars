﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /* You have to do God's job. The creation method must return an array of length 2 containing objects (representing Adam and Eve). 
     * The first object in the array should be an instance of the class Man. The second should be an instance of the class Woman. 
     * Both objects have to be subclasses of Human. Your job is to implement the Human, Man and Woman classes.
    */
    public class God
    {
        public static Human[] Create()
        {
            return new Human[] { new Man(), new Woman() };
        }
    }

    public class Human { }

    public class Man : Human { }

    public class Woman : Human { }
}
