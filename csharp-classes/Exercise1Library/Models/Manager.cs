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

        public Manager():base()
        {
            
        }
        public Manager(string firstName, string lastName, Role role, double salary) :base(firstName, lastName,  role, salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }
        private double Bonus { get; set; }

    
        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
