using System.Diagnostics;
using System.Xml.Linq;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<string> studentNames = new List<string>();


            studentNames.Add("Djordje");
            studentNames.Add("Goran");
            studentNames.Add("Tamara");

            studentNames.Remove("Tamara");

            Console.WriteLine("Tudent names:");
            foreach (string name in studentNames)
            {
                Console.WriteLine(name);
            }

            string search = "Tamara";

            if (studentNames.Contains(search))     //bool
            {
                Console.WriteLine(search);
            }

            int numOfSelements = studentNames.Count;


            List<int> numbers = new List<int>() { 10,52,48,78};

            int numOfIndex = numbers[2];

            ;
            Console.WriteLine(numbers.ElementAt(2));
            numbers.RemoveAt(2);


            //Dictionary

            Dictionary<string, int> studentGrades = new Dictionary<string, int>();


            studentGrades.Add("Djordje", 10);
            studentGrades.Add("Tamara", 10);
            studentGrades.Add("John", 7);
            studentGrades.Add("Bob", 8);

            foreach (KeyValuePair<string,int> grade in studentGrades)
            {
                Console.WriteLine($"Student {grade.Key} - ocjena {grade.Value}");
            }

            if (studentGrades.ContainsKey("Milica"))
            {
                Console.WriteLine($"There is Milica");
            }

            if (studentGrades.ContainsValue (7))
            {
                Console.WriteLine($"There is grade 7");
            }

            studentGrades.Count();//cuva se u tipu variajble KeyValuePair<string,int>

            int ocena = studentGrades["John"]; //vidi zasto crveni



            Dictionary<string, bool> toDoList = new Dictionary<string, bool>()
            {
                {"Wash a car", true  },
                {"Go groceries shoping", false },
            };

            //Queue and stack


            //Last in - First Out
            //Enqueu()
            //Dequeue()
            //Peek();ispisuje sledeci element u u queue


            //stack last in-first out

            Stack<string> cookies = new Stack<string>();

            cookies.Push("Prvi keks");
            cookies.Push("Drugi keks");
            cookies.Push("Treci keks");

            cookies.Pop();
            cookies.Peek();





        }
    }
}
