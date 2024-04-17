namespace WorkingWitthDates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime currentDate = new DateTime(2020,4,16,18,3,0);
            DateTime currentDay= DateTime.Today;
            DateTime currentDateTame = DateTime.Now;

            Console.WriteLine(currentDate);
            Console.WriteLine(currentDay);
            Console.WriteLine(currentDateTame);

            string dateFormat1 = currentDateTame.ToString("dd/MM/yyyy");
            Console.WriteLine(dateFormat1);


            string dateFormat2 = currentDateTame.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine(dateFormat2);

            DateTime dateAfter100Days = currentDateTame.AddDays(100);
            Console.WriteLine(dateAfter100Days);

            DateTime removed10000Days = currentDateTame.AddDays(-1000);
            Console.WriteLine(removed10000Days);

            //.addHours

            
        }
    }
}
