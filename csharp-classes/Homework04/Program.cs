using System.Security.Cryptography.X509Certificates;

namespace Homework04
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter year of birth(yyyy):");
            int yearInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mounth of birth(MM):");
            int mounthInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter day of birth(dd):");
            int dayInput = int.Parse(Console.ReadLine());


            DateTime myBirthDay = new DateTime(yearInput, mounthInput, dayInput);

            DateTime currentDay = DateTime.Today;

            TimeSpan difference = currentDay - myBirthDay;//TimeSpan vraca dane, sate, minute

            double yearsD = difference.Days / 365.25;
            int years = Convert.ToInt32(yearsD);

            int remainingDays = difference.Days % 365;
            int months = remainingDays / 30;

            Console.WriteLine($"Your age is: {years} years and {months} months ");



        }

    }

}
