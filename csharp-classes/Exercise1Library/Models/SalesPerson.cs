using ExerciseLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLibrary.Models
{
    public class SalesPerson : Employee
    {
        

        public SalesPerson():base()
        {
            
        }
        public SalesPerson(string firstName, string lastName, Role role, double salary) :base(firstName, lastName, role, salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Sales;
            Salary = 500.00;

        }
        private double SuccessSaleRevenue { get; set; }
        public void AddSuccessRevenue(double revenue)
        {
            SuccessSaleRevenue = revenue;
        }

        public override double GetSalary()
        {
            base.GetSalary();
            double Bonus = 0;
            if (SuccessSaleRevenue <= 2000)
            {
                Bonus = 500;
            }
            else if(SuccessSaleRevenue > 2000 && SuccessSaleRevenue < 5000)
            {
                Bonus = 1000;
            }
             else if (SuccessSaleRevenue > 5000)
            {
                Bonus = 1500;
            }

            return Salary + Bonus;

        }


    }
}
