namespace class04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //methods,dates and strings

            //Console.WriteLine("Hello, World!");
            SayHallo();
            string message = PrintMyName("Almir");
            Console.WriteLine(PrintMyInfo("Milica","Dujakovic"));


            Console.WriteLine("Enter  - or  + ");
            string input = Console.ReadLine();


            Console.WriteLine("Enter first num: ");
            int num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter second num: ");
            int num2 = int.Parse(Console.ReadLine());

            if (input == "-")
            {
                Console.WriteLine(Substract(num1, num2));
            }else if(input == "+")
            {
                Console.WriteLine(Sum(num1, num2));
            }
            else
            {
              Console.WriteLine("No that operation available.");
            }



           



        }
        //ako ne vraca nista mora biti void
        static void SayHallo() 
        {
            Console.WriteLine("Hallo from our firs method!");
        }

        static string PrintMyName(string name)
        {
            string message = "Hi from print method";
            return message;
        }
        static string PrintMyInfo(string firsName, string lastName)
        {
            
            return $"{firsName},{lastName}";
        }


        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }


    }
}
