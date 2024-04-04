namespace Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise 3
            char star = '*';
            Console.WriteLine($"    {star}");
            Console.WriteLine($"   {star}{star}{star}");
            Console.WriteLine($"  {star}{star}{star}{star}{star}");
            Console.WriteLine($" {star}{star}{star}{star}{star}{star}{star}");
            Console.WriteLine($"{star}{star}{star}{star}{star}{star}{star}{star}{star}");
            //exercise 4
            Console.WriteLine($"      {star}");
            Console.WriteLine($"      {star}");
            Console.WriteLine($"   {star}  {star}  {star}");
            Console.WriteLine($"  {star}   {star}   {star} ");
            Console.WriteLine($"      {star}");
            Console.WriteLine($"      {star}");
            Console.WriteLine($"   {star}     {star} ");
            Console.WriteLine($"  {star}       {star} ");
        }
    }
}
