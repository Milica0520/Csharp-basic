using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace class03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //for loop
            for (int i = 0; i < 10 ; i++)
            {
                Console.WriteLine($"The value of i : {i}");
            }

            for (; ; )
            {
                Console.WriteLine($"Endless loop");

                string input = Console.ReadLine();
                if (input == "X" || input == "x")
                    break;
            }

            //forr -reverse loop

            //while
            int counter = 0;


            while (counter < 10)
            {
                Console.WriteLine($"The value is: {counter}");
                counter++;
            }




            int doWhileCounter = 0;


            do
            {
                Console.WriteLine("Do smt.");
                doWhileCounter++;

            } while (doWhileCounter < 10);
            */

            //exercise 1
            /*Exercise 1:
            Get an input number from the console
            Print all numbers from 1 to that number
            Get another input number from the console
            Print all numbers from that number to 1
             */

            /*
            Console.WriteLine("Enter number: ");
            int iputNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= iputNum; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Enter number: ");
            int iputNum2 = int.Parse(Console.ReadLine());
            for (int i = iputNum2; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            
            /*
            Exercise 2: 
            Get an input number from the console Print all even numbers starting from 2
            Get another input number from the console Print all odd numbers starting from 1
            */
            /*
            Console.WriteLine("Enter number: ");
            int iputNum3 = int.Parse(Console.ReadLine());

            for (int i = 2; i < iputNum3; i++)
            {
                if(i %2 == 0)
                {
                    Console.WriteLine($"Even: {i}");
                }
                else if(i % 2 != 0)
                {
                    Console.WriteLine($"Odd: {i}");
                }
              
            }
           */
            /*Exercise 3:
            Get an input from the console 
            Print all numbers from 1 to that number
            Don’t print numbers that can be divided by 3 or 7
            If the number gets to 100 print a message: The limit is reached and stop counting
             */
       /*
            Console.WriteLine("Enter number: ");
            int iputNum4 = int.Parse(Console.ReadLine());


            int j = 1;

            while (j < iputNum4)
            {
                if (j == 100)
                {
                    Console.WriteLine("The limit is reached and stop counting.");
                    break;
                }

                if (j % 3 == 0 || j % 7 == 0)
                {
                    j++;
                    continue;
                }

                Console.WriteLine(j);
                j++;
            }
       */
            /*
            int[] nymberArr = new int[5];


            for (int i = 0; i < nymberArr.Length; i++)
            {
                Console.WriteLine(nymberArr[i]); 
            }

            string[] studentsArr = { "Milica", "Tamara", "Goran", "Stefan", "Sava"};


            foreach (string student in studentsArr)
            {
                Console.WriteLine(student);
                if (student == "Tamara")
                break;
            }
            */

            //exercise
            /*
            Exercise 1:
            Declare 5 arrays with 5 elements in them:
            With words
            With decimal values
            With characters from keyboard
            With true / false values
            */

            /*
            string[] nymbersArray = new string[5];

            decimal[] decimalArray = new decimal[5];

            char[] charArray = new char[5];

            bool[] booleanArray = new bool[5];
            */
            /*
            Exercise 2:
 
            Declare a new array of integers with 5 elements
            Initialize the array elements with values from input
            Sum all the values and print the result in the console
            */




            /*
            Console.WriteLine("Enter four numbers devided by space: ");
            string inputNums = Console.ReadLine();

            string[] numbers = inputNums.Split(' ');

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }

            Console.WriteLine($"The sum of numbers {sum}");
            */

            /*
           Exercise 3:

           Create an array with names
           Give an option to the user to enter a name from the keyboard
           After entering the name put it in the array
           Ask the user if they want to enter another name(Y / N)
           Do the same process over and over until the user enters N
            Print all the names after user enters N
            */

           
            string[] names = new string[] {} ;

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Enter name: ");
                string inputName = Console.ReadLine();
                names[i] = inputName;
                if(inputName == "N" && inputName == "n")
                {
                    foreach (string item in names)
                    {
                        Console.WriteLine(names[i]);
                    }
                }
               
            }
            

         //   Console.WriteLine("Enter another name: ");
            
    

        }
    }
}
