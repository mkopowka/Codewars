using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Your task is to complete this Class, the Person class has been created. You must fill in the Constructor method to accept a name as string and an age as number, 
     * complete the get Info property and getInfo method/Info getter which should return johns age is 34
     * */
    internal class Persons
    {
        private string name;
        private int age;
        public Persons(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Info => $"{name}s age is {age}";

        public string GetInfo()
        {
            return $"{name}s age is {age}";
        }

    }
}
