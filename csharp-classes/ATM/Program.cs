using ATM.Models;
using System.Reflection.Metadata;

namespace ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
             


            Customer customer1 = new Customer("Bob", "Bobsky", "1234-1234-1234-1234", "1111", 4325);
            Customer customer2= new Customer("Tamara ", "Zdravkovic", "1111-2222-3333-4444", "2222", 8657.25);
            Customer[] customers = new Customer[] { customer1, customer2 };


            Console.WriteLine("Welcome to the ATM app \n Please enter your card numer: ");       
            string cardNumInp = Console.ReadLine(); 

            Console.WriteLine("Enter your pin code: ");
            string pinCodeInp = Console.ReadLine();



            bool customerFound = false;
            Customer currCostumer = null;

            foreach (Customer customer in customers)
            {
                if(customer.CardNo == cardNumInp && customer.PinCode == pinCodeInp)
                {
                    customerFound = true;
                    Console.WriteLine($"Welcome {customer.FirstName} {customer.LastName}!");
                    currCostumer = customer;
                }
            }

            if(customerFound == false)
            {
                Console.WriteLine("You entered wrong card number or pin code.");
                return;
            }

            Console.WriteLine("What would you like to do: \n1.Check Balance\n2.Cash Withdrawal\n3.Cash Deposit");
            string optionInp = Console.ReadLine();

           
                switch (optionInp)
            {
                case "1":
                    currCostumer.BalanceChecking();
                     break;
                case "2":
                    Console.WriteLine("Enter amout to withdrawl:");
                    double moneyInp = double.Parse(Console.ReadLine());
                    currCostumer.CashWithdrawal(moneyInp);
                     break;
                case "3":
                    Console.WriteLine("Enter amout to deposite:");
                    double moneyInp3 = double.Parse(Console.ReadLine());
                    currCostumer.CashDeposition(moneyInp3);
                     break;
                default:
                    Console.WriteLine("That option is not available.");
                     break;
                }


          

        }
    }
}
