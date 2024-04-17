using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOOP.Models
{
    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human() { }



        //Constructor 
        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Human(Human otherHuman)
        {
            FirstName = otherHuman.FirstName;
            LastName = otherHuman.LastName;
            Age = otherHuman.Age;

        }



        public string GetPersonStatc()
        {
           return  $"My name is {FirstName} {LastName} and I am {Age} years old";
        }
    }
}
