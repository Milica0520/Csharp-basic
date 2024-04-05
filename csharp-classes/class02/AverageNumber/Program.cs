namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter four numbers devided by space: ");
            string inputNums = Console.ReadLine();

            string[] numbers = inputNums.Split(' ');

            int sum = 0;

            for(int i = 0; i < numbers .Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }

            decimal averige = sum / numbers.Length;

            Console.WriteLine($"The average of {string.Join(", ", numbers)} is: {averige}");

        }
    }
}
