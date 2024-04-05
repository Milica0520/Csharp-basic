namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the First number: ");
            int inputNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second number: ");
            int inputNum2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the Operation (+, - , * , / ): ");
           string operationInp =Console.ReadLine();

            switch (operationInp) {
                case "+":
                    Console.WriteLine(inputNum1 + inputNum2);
                    break;
                case "-":
                    Console.WriteLine(inputNum1 - inputNum2);
                    break;
                case "*":
                    Console.WriteLine(inputNum1 * inputNum2);
                    break;
                case "/":
                    Console.WriteLine(Math.Round((Convert.ToDecimal(inputNum1) / inputNum2),2, MidpointRounding.AwayFromZero));
                    break;
            }


        }
    }
}
