using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace data_types_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //exercise 1
            double x;
            double y;
            x = 5.92547;
            y = 1.03788;

            double divideDouble = x / y;

            int z;
            int q;
            z = 10;
            q = 3;

            float devideInt = z / q;
            int devideInt2 = z / q;
            Console.WriteLine($"{divideDouble} {devideInt} {devideInt2}");

            //exercise 2
            /*
            Declare two string variables
            Initialize them and concatenate them in a new variable
            //
            Declare two string variables
            Initialize them with the number 9 and 3
            Concatenate them in a new variable
            Print the results in the console
            */

            string fName;
            string lName;

            fName = "Milica";
            lName = "Dujakovic";

            string fullName = fName + " " + lName;

            string nine;
            string three;

            nine = "9";
            three = "3";
            string concatExe = nine + three;


            Console.WriteLine(fullName);
            Console.WriteLine(concatExe);

            //exercise 3
            /*
            Declare an integer and a string variable
            Initialize them and concatenate them in a new variable
            Print the result in the console
            */
            int num1;
            string str1;

            num1 = 7;
            str1 = "broj";

            string concat2 = num1 + str1;

            Console.WriteLine(concat2);

            //exercise 4
            /*
            You have n credits on your mobile bill. One SMS costs m credits.
            How many SMS messages you can send? n = 102
            m = 5
            Result = ?
            */

            int n = 102;
            int m = 5;

            int numOfSms = n / m;
            Console.WriteLine(numOfSms);
            
            
            
            
            








            /*
            //exercise 5


            int n1 = 8;
            int m1 = 5;

            Console.WriteLine("Unesite broj stabala:");
            int userInput = int.Parse(Console.ReadLine());

            int result = userInput * 12 * n1 / m1;


            Console.WriteLine($"Potrebno vam je {result} korpi da pokupite jabuke.");


            //exercise 6-- not done

            Console.WriteLine("Unesite prvi broj: ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Unesite drugi broj: ");
            string input2 = Console.ReadLine();

            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);

            //code that can test which number is larger
            string result2;

            if (number1 > number2)
            {
                result2 = "Prvi broj je veci od drugog";
            }
            else if (number1 < number2)
            {
                result2 = "Drugi broj je veci od prvog";
            }
            else
            {
                result2 = "Brojevi su jednaki";
            }

            Console.WriteLine(result);
            Console.ReadKey();

            // code that can test the numbers whether they are even or odd
            if (number1 % 2 == 0)
            {
                Console.WriteLine("Broj je paran");
            }
            else
            {
                Console.WriteLine("Broj je neparan");
            };

            */
            //exercise 7 
            /*
            Console.WriteLine("Unesite broj od 1 do 3!");
            int inputNum = int.Parse(Console.ReadLine());


            if (inputNum != 1 && inputNum != 2 && inputNum != 3)
            {
                Console.WriteLine("Unijeli ste pogresan broj!");
            }
            if (inputNum == 1)
            {
                Console.WriteLine("You got a new car!");
            }if(inputNum == 2)
            {
                Console.WriteLine("You got a new plane!");
            }
            if (inputNum == 3)
            {
                Console.WriteLine("You got a new bike!");
            }

           */

        }
    }
}
