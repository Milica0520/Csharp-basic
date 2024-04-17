using ClassesOOP.Models;

namespace ClassesOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Profesor 1 
            Teacher profesor1 = new Teacher();

            profesor1.Age = 29;
            profesor1.FirstName = "Profesor";
            profesor1.LastName = "Jedan";
            profesor1.Email = "profesor1@gmail.com";
            profesor1.LearningModules = new string[] { "C# Basic", "Advanced C#" };
            profesor1.SetYearOfAword("2004");
         

            

            //Profesor 2
            Teacher profesor2 = new Teacher();

            profesor2.Age = 40;
            profesor2.FirstName = "Profesor2";
            profesor2.LastName = "Dva";
            profesor2.Email = "profesor2@gmail.com";
            profesor2.LearningModules = new string[] { "Database Development" };

            Human robinsonCruso = new Human();

            Console.WriteLine("Enter your first name: ");
            robinsonCruso.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            robinsonCruso.LastName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            robinsonCruso.Age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Our human is: {robinsonCruso.GetPersonStatc()}");
          

            string fName = "Goran";
            string lName = "Radenkovic";
            int age = 25;


            Human human2 = new Human(fName,lName, age);
            Console.WriteLine(human2.GetPersonStatc());


            Human human3 = new Human(human2);
            Console.WriteLine(human3.GetPersonStatc());


            //exercise dog

            Dog dog1 = new Dog();
            Console.WriteLine("Enter dogs name: ");
            dog1.Name = Console.ReadLine();

            Console.WriteLine("Enter dogs race: ");
            dog1.race = Console.ReadLine();

            Console.WriteLine("Enter dogs color: ");
            dog1.color = Console.ReadLine();

            Console.WriteLine("What do you want your dog to do? Options: Eat, Play, ChaseTail");
            string action = Console.ReadLine();

            switch (action)
            {
                case "Eat":
                    Console.WriteLine(dog1.Eat());
                    break;
                case "Play":
                    Console.WriteLine(dog1.Play());
                    break;
                case "ChaseTail":
                    Console.WriteLine(dog1.ChaseTail());
                    break;
                default:
                    Console.WriteLine("That option is not avelible");
                    break;
            }
           




        }
    }
}
