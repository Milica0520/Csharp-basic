using class07.Models;

namespace class07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter first name:");
            string nameInp = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            string lastNameInp = Console.ReadLine();

            Console.WriteLine("Enter age:");
            int ageInp = int.Parse(Console.ReadLine());

            Human human1 = new Human(nameInp, lastNameInp, ageInp);
        
            Console.WriteLine(human1.GetPersonStats());
            */
            //dog
            /*
            Console.WriteLine("Enter dogs name :");
            string dogNameInp = Console.ReadLine();

            Console.WriteLine("Enter dogs race:");
            string dogRaceInp = Console.ReadLine();

            Console.WriteLine("Enter dogs color:");
            string dogColorInp = Console.ReadLine();

            Dog dog1 = new Dog(dogNameInp, dogRaceInp, dogColorInp);

            Console.WriteLine("Choose action for your dog: Eat, Play, ChaseTail.");
            string actionInp = Console.ReadLine();

            switch (actionInp)
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
                    Console.WriteLine("That action is not available");
                    break;
            }
            */

            //exercise 3

            Student[] students = new Student[3] ;
            //

            for(int i  = 0; i < 3; i++)
            {
                Console.WriteLine("Enter studen full name:");
                string fullNameInp = Console.ReadLine();

                Console.WriteLine("Enter Academy name:");
                string academyInp = Console.ReadLine();

                Console.WriteLine("Enter Group name:");
                string groupInp = Console.ReadLine();

                Student student = new Student(fullNameInp, academyInp, groupInp);

                students[i] = student;
                
            }

            Console.WriteLine("Search student name:");
            string nameInp = Console.ReadLine().ToLower();


            bool itemFound = false;

            foreach(Student item in students)
            {
                if(item.Name.ToLower() == nameInp)
                {
                    itemFound = true;
                    Console.WriteLine($"{item.Name} {item.Academy} {item.Group}");
                }
                     
            }
            
            if(itemFound == false)
                Console.WriteLine("No student with this name.");
        }
    }
}
