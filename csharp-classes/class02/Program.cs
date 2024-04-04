namespace class02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data types
            /*
            int itegerVariable1 = 5;
            int itegerVariable2 = 0;

            string itegerVariable3 = "Almir";

            int variable3 = 3100020;

            Console.WriteLine("Vrijednost varijable 1 : " + itegerVariable1);
            Console.WriteLine("Vrijednost varijable 1 : " + itegerVariable2);

            itegerVariable1 = 500;
            itegerVariable1 = 1000;

            Console.WriteLine("Vrijednost varijable 1 : " + itegerVariable1);

            //uint positivNumberOnly = 300; not in use often

            float floatVAriable = 2.5f;
            double doubleVariable = 2.5;

            Console.WriteLine("Vrijednost floatVAriable  : " + floatVAriable);
            Console.WriteLine("Vrijednost doubleVariable  : " + doubleVariable);

            string message = "Hallo students";
            char singelCharValue = 'a';
            Console.WriteLine(singelCharValue);
            Console.WriteLine(message);
            bool isEnabled = false;//uvijek pocinje sa pitanjem is zbog logike;0
            bool isPrinted = true;//1


            Console.WriteLine(isPrinted);
            Console.WriteLine(isEnabled);

            string firstName = "Almir";

            string CONFIGURATION_KEY_ID = "564658765";//VELIKIM SLOVIMA SAMO NEKE KONSTANTE

            Console.WriteLine(firstName);
            Console.WriteLine(CONFIGURATION_KEY_ID);

            //OPERATORS


            int firstNum = 10;
            int secondNum = 5;


            int sum = firstNum + secondNum;

            Console.WriteLine(sum);

            firstNum++; //unarni operator
            firstNum--;

            ++firstNum; 
            */
            /*
            Console.Write("Write your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Your name is: {userName}");


            Console.Write("How old are you: ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your are {userAge} years old age.");

            int userAge2 = Convert.ToInt16(userAge);

            Console.WriteLine($"Your are {userAge2} years old age.");

            Console.WriteLine("What is the value of pi?");

            double piValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(piValue);
            */
            /*
            Console.WriteLine("Type any positive or negative number:");
            int userInpNum = Convert.ToInt32(Console.ReadLine());

            if(userInpNum > 0)
            {
                Console.WriteLine("Number is positive");
            } else if (userInpNum < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
            */


            Console.WriteLine($"1. Monday\n2. Tuesday\n3. Wednesday\n4. Thursday\n5. Friday\n6. Saturday\n7.Sunday");

            int userInpDay = Convert.ToInt32(Console.ReadLine());

            switch(userInpDay)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Work day : ");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Happy");
                    break;
                default:
                    Console.WriteLine("Outside of valid values!");
                    break;
            }

        }
    }
}
