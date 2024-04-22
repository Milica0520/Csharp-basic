using CommonModels.Enums;
using CommonModels.Models;

namespace AnotherConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Student milica = new Student();

            milica.FirstName = "Milica";

            milica.LastName = "Dujakovic";

            milica.Gender = Gender.Fimale;


            milica.PrintInfo();
        }
    }
}
