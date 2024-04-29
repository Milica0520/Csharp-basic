using ExerciseLibrary.Enums;

namespace ExerciseLibrary.Models
{
    public class Employee
    {

        public Employee()
        {
            
        }
        public Employee(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;

        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Role Role { get; set; }

        protected double Salary { get; set; }

        public string PrintInfo()
        {
            return $"Employee full name: {FirstName} {LastName} - salary: {Salary}";
        }
        virtual public double GetSalary()
        {
            return Salary;
        }


    }
}
