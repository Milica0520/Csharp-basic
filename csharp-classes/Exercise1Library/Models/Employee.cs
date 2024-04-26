using ExerciseLibrary.Enums;

namespace ExerciseLibrary.Models
{
    public class Employee
    {
        public Employee()
        {
            
        }
        public Employee(string FirstName, string LastName, Role Role)
        {
            FirstName = FirstName;
            LastName = LastName;
            Role = Role;
            Salary = 500;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Role Role { get; set; }

        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Employee info - {FirstName},{LastName} , salary - {Salary}");
        }

        public virtual double GetSalary()
        {
            return  Salary;
        }

    }
}
