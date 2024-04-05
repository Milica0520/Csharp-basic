namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the First Number: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the Second Number: ");
            int y = int.Parse(Console.ReadLine());


            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($" First Number is {x} and Second Number is {y}");



        }
    }
}
