using ExerciseLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLibrary.Models
{
    public class SalesPerson : Employee
    {

        public SalesPerson()
        {
            
        }
        public SalesPerson(string FirstName, string LastName, Role Role, double Salary, double SuccessSaleRevenue) : base( FirstName, LastName, Role, Salary)
        {
            SuccessSaleRevenue = SuccessSaleRevenue;
        }
        

        private double SuccessSaleRevenue { get; set; }

        public void AddSuccessRevenue()
        {
            SuccessSaleRevenue = 100.00;
        }


        public override double GetSalary()
        {

            if(SuccessSaleRevenue <= 2000)
            {

            }
            return Salary;
        }



    }
}
