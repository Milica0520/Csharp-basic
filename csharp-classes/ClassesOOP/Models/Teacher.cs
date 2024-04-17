﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOOP.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set;  }
        public string LastName { get; set;   }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set;  }
        public string Email { get; set; }
        public string CurrentJobTitele { get; set;  }
        public string[] LearningModules { get; set;  }

         private string YearOfAword { get; set; }

        public void SetYearOfAword(string yearOfAword)
        {
            if(YearOfAword == "2024")
            {
                Console.WriteLine("Ova godina nije podrzana");
            }
            YearOfAword = yearOfAword;
        }


        public void SayHallo()
        {
            Console.WriteLine($"Hi, my name is {FirstName} {LastName} and I am {Age} years old, btw I won the aword {YearOfAword}");
        }
        
        


    }
}
