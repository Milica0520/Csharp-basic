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

            double result = 0;
            switch (operationInp) {
                case "+":
                    result = inputNum1 + inputNum2;
                    break;
                case "-":
                   result = inputNum1 - inputNum2;
                    break;
                case "*":
                   result = inputNum1 * inputNum2;
                    break;
                case "/":
                   result =  inputNum1 / inputNum2;
                    break;
            }

            Console.WriteLine($"Result is : {result}");
        }
    }
}
