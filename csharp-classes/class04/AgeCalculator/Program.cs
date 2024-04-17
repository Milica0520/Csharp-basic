namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgeCalculator();
        }

        static void AgeCalculator( )
        {

            DateTime date = DateTime.Now;
           // Console.WriteLine(date);//  4 / 17 / 2024 11:51:06 AM


            Console.WriteLine("Enter your birth date (ex. MM/dd/yyyy)")
            string birtDateString = Console.ReadLine();

        
            string format = "MM/dd/yyyy";

          
            DateTime birthDate;
            if (DateTime.TryParseExact(datumString, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out birthDate))
            {
                Console.WriteLine("Pretvorili ste string u datum: " + birthDate.ToString("dd/MM/yyyy"));
            }
            else
            {
                Console.WriteLine("Neuspješno pretvaranje stringa u datum.");
            }



        }
        
    }
}
