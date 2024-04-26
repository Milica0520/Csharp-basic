using ExerciseLibrary.Enums;
using ExerciseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLibrary.Models
{
    public class Manager : Employee
    {
        public Manager()
        {
            
        }
        public Manager(string FirstName, string LastName, Role Role)
        {
            FirstName = FirstName;
            LastName = LastName;
            Role = Role;
            Salary = 500;
        }


        double Bonus { get; set; }


        public override double GetSalary()
        {

            base.GetSalary();
            return Salary + Bonus;
        }


    }
}
