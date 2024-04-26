namespace ExeptionsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///try//catch
            try
            {
                int number = Convert.ToInt32(0);
                double result = 10 / number;

                //
                SquareRoot(number);

            }
            catch(FormatException ex)
            {
                Console.WriteLine("Your input not in correct form.Please, try again!");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You tried to divide by zero.Please, try again!");
            }
            catch
            {
                Console.WriteLine("Some wird error hapend. Try again");
            }
            finally
            {
                Console.WriteLine("This part of the code will always execute!");
            }


            Console.WriteLine("SomThe code riched athis line:::::::::::::::::");


        }

        static double SquareRoot (double x)
        {
            if( x < 0) { 
            throw new Exception("Ne moze se korjenovati negativan broj.");
            }

            return Math.Sqrt(x);
        }
    }
}
