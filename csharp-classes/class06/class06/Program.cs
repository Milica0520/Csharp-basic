namespace class06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //exercise 1

            string myString = "The whole group of G1 loves C#.Thay find learning this language fun and easy!";

            string[] myString2 = myString.Split(".");

            foreach (var item in myString2)
            {
                Console.WriteLine(item);
            }

            //exercise 2

            Console.WriteLine("Enter number!");
            int myInt = int.Parse(Console.ReadLine());
   
            NumberStats( myInt);

        }

        static void NumberStats(int myNumber)
        {


            if (myNumber > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }

            if (myNumber % 10 > 0)
            {
                Console.WriteLine("Decimal");
            }
            else
            {
                Console.WriteLine("Integer");
            }

            if (myNumber % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

        }
    }
}
