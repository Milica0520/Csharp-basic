using ExerciseLibrary.Models;

namespace ExercisesInteritance
{
    public class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee("Bob","Bobsky", ExerciseLibrary.Enums.Role.Sales, 500.00 );

            employee1.PrintInfo();
            employee1.GetSalary();
           



            
        }
    }
}
