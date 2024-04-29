using ExerciseLibrary.Models;

namespace ExercisesInteritance
{
    public class Program
    {
        static void Main(string[] args)
        {

            Employee firstEmployee = new Employee("Pera","Mitic", ExerciseLibrary.Enums.Role.Sales, 500);
            Console.WriteLine(firstEmployee.PrintInfo());
            Console.WriteLine(firstEmployee.GetSalary());
         


            SalesPerson salesPerson = new SalesPerson("Katarina" ,"Andjelic", ExerciseLibrary.Enums.Role.Sales, 1200);

            
            salesPerson.AddSuccessRevenue(150);
            Console.WriteLine(salesPerson.PrintInfo());
            Console.WriteLine(salesPerson.GetSalary());

            Manager menagerEmployee = new Manager("Pantelija", "Topalovic", ExerciseLibrary.Enums.Role.Manager, 2500);
        
            menagerEmployee.AddBonus(20);
            Console.WriteLine(menagerEmployee.PrintInfo());
            Console.WriteLine(menagerEmployee.GetSalary());


        }
    }
}
