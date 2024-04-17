using System.Runtime.CompilerServices;

namespace WorkWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Almir";

            string hello1 = "Hello" + name;
            string hello2 = string.Format("Hello {0}", name);
            string hello3 = $"Hello {name}";

            Console.WriteLine(hello1);
            Console.WriteLine(hello2);
            Console.WriteLine(hello3);

            //string formating


            //metoda format
            string currency = string.Format("{0:C}", 125.45);
            string percent = string.Format("{0:P}", 0.45);
            string customFormat = string.Format("{0:0##- ### - ###}", 065111343);
            string customAligment = string.Format("| {0,10} | {1,10} |", "Id", "Order");



            Console.WriteLine("Currency formatting :" + currency);
            Console.WriteLine("Currency formatting :" + percent);
            Console.WriteLine(customFormat);
            Console.WriteLine(customAligment);

            //escaping strings

            string a = "Your file is located at : C:\\Users\\Public";
            string b = "We will have \"fair\" elections ";
            string c = "This is first par before new line \n This is naw new line.";
            string e = "In C# we use \\n to go into new line";

            string aa = @"Your file is located at : C:\\Users\\Public";
            string bb = @"We will have ""fair"" elections ";
            string cc = @"This is first par before new line \n This is naw new line.";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(e);
            Console.WriteLine(aa);
            Console.WriteLine(bb);
            Console.WriteLine(cc);

            string ourString = "       We are learning C#.         ";

            string lowerC = ourString.ToLower();

            string upperC  = ourString.ToUpper();

            Console.WriteLine(lowerC);
            Console.WriteLine(upperC);

            //Length

            Console.WriteLine(ourString.Length);

            string[] splitedStr = ourString.Split('.');


            foreach( string item in splitedStr)
            {
                Console.WriteLine(item);
            }

            string trimmedString = ourString.Trim();
            Console.WriteLine(trimmedString);

            //join()

            string part1 = "This is fourth class";
            string part2 = "of C#";
            string part3 = "learning";


            string[] academy = new string[]
            {
             part1,  part2 , part3
            };

            string joinedContent = string.Join(", ", academy);


            int indexOfword = ourString.IndexOf("FUN");
            int indexOfwordName = ourString.IndexOf("Milica");//trazena rijec se ne nalazi u stringu -1

            //Contains
            Console.WriteLine(indexOfword);
            Console.WriteLine(indexOfwordName);


            if (ourString.Contains( "FUN")){
                Console.WriteLine("The string contains");
            }

         //  string partOfString = ourString.Substring(indexOfword, ourString.Length - indexOfword);
          //  Console.WriteLine(partOfString);

            Substrings();


        }

        static void Substrings()
        {

            string x = "Hello from SEDC Codecademy 2024";
            Console.WriteLine($"Enter number  :");
            int myNumber = int.Parse(Console.ReadLine());

            if ( myNumber < 0 || myNumber > x.Length)
            {
                Console.WriteLine("There is no element with that index number in this string");
            }
            else
            {
                string element = x.Substring(myNumber, x.Length - myNumber);
                Console.WriteLine(element.Trim()[0]);
            }

        }
 

    }
}
