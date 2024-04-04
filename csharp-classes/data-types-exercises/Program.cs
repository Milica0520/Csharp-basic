namespace data_types_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
            string fname;
            string lname;
            fname = "Milica";
            lname = "Dujakovic";

            string fullname = fname + lname;

            string nine;
            string three;

            nine = "9";
            three = "3";
            string concatExe = nine + three;


            Console.WriteLine(fullname);
            Console.WriteLine(concatExe);

            //exercise 3
            int num1;
            string str1;

            num1 = 7;
            str1 = "broj";

            string concat2 = num1 + str1;

            Console.WriteLine(concat2);

            //exercise 4

            int n = 102;
            int m = 5;

            float sms = n / m;
            Console.WriteLine(sms);


            //exercise 5

          
          
            int n1 = 8;
            int m1 = 5;
           
            Console.WriteLine("Unesite broj stabala:");
            int userInput =int.Parse( Console.ReadLine());

            int result = userInput * 12 * n1 / m1;


            Console.WriteLine($"Potrebno vam je {result} korpi da pokupite jabuke.");
            */

            //exercise 6-- not done

            Console.WriteLine("Unesite prvi broj :");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj :");
            int input2 = int.Parse(Console.ReadLine());


            //code that can test which number is larger
          
            if (input1 > input2)
            {
                Console.WriteLine("Prvi broj je veci");
            }else if (input1 < input2)
            {
               Console.WriteLine("Drugi broj je veci");
            }else
            {
               Console.WriteLine("Brojevi su jednaki");
            };

            // code that can test the numbers whether they are even or odd
            if (input1%2 == 0)
            {
                Console.WriteLine("Broj je paran");
            }
            else 
            {
                Console.WriteLine("Broj je neparan");
            };


            //exercise 7 

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

           

        }
    }
}
