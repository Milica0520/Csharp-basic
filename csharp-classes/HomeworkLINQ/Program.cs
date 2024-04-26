using System.Diagnostics;

namespace HomeworkLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Svojom logikom(a drugu trenyutno nemam:))))))) nisam mogla zakljuciti sta da se desi kada pritisnem N
            Queue<int> numbers = new Queue<int>();
            Console.WriteLine("Enter some numbers.If you want to stop entering numbers press Y.");
            bool isYes = false;
            do
            {
                Console.WriteLine("Enter a number or Y");
                string input = Console.ReadLine();

                if (input.ToUpper() == "Y")
                {
                    Console.WriteLine("Entered number are:");
                    if (numbers.Count() > 0)
                    {
                        foreach (int num in numbers)
                        {
                            Console.WriteLine($"{num}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You haven't entered any numbers yet. Try again.");
                    }
                    isYes = true;
                }
                else if (input.ToUpper() == "N")
                {

                }
                else
                {
                    //u ovom bloku sam htjela samo uzeti input prebaciti u int i dodati u queue kako smo radili ali nije moglo tako.
                    //Satvrno sam bila zapela. Liniju 40 mi je pomogao gtp :( 
                    int usersNumInp;
                    if (int.TryParse(input, out usersNumInp))
                    {
                        numbers.Enqueue(usersNumInp);
                        isYes = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        isYes = false;
                    }
                }
            } while (!isYes);








        }
    }
}
