using System;
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
            Man adam = new Man("Adam");
            Woman eve = new Woman("Eve");

            Human[] humans = new Human[] { adam, eve };
            return humans;
        }

    }
    public class Human
    {
        public string Name { get; set; }
        public Human(string name)
        {
            Name = name;
        }
    }
    public class Man : Human
    {
        public Man(string name) : base(name)
        {
        }

        public string ManName(string name)
        {
            return name;
        }
    }
    public class Woman : Human
    {
        public Woman(string name) : base(name)
        {
        }

        public string WomanName(string name)
        {
            return name;
        }
    }

}
