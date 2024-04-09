namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = new int[6];

            Console.WriteLine("Enter integers: ");

            int sum = 0;
            for(int i = 0; i  < myArray.Length; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                if ( inputNum % 02 == 0)
                {
                    sum += inputNum;
                }
            }

            Console.WriteLine($"The result is:{sum}");
        }
    }
}
