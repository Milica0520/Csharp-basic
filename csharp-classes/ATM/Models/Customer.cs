using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    public class Customer
    {
        public Customer()
        {
            
        }
        public Customer(string FirstName, string LastName, string CardNo, string PinCode, double OwnedMoney)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.CardNo = CardNo;
            this.PinCode = PinCode;
            this.OwnedMoney = OwnedMoney;
        }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string CardNo { get; set; }

        public string PinCode { get; set; }

        public double OwnedMoney { get; set; }

        public double tempMoneyVariaable { get; set; }


        public void BalanceChecking()
        {
            Console.WriteLine($"Your current balance is: {string.Format("{0:C}",OwnedMoney)}");
        }

        public void CashWithdrawal( double tempMoneyVariaable)
        {
            if(OwnedMoney > tempMoneyVariaable)
            {
                Console.WriteLine($"You withdrew {string.Format("{0:C}",tempMoneyVariaable)}." +
                    $"You have {string.Format("{0:C}", OwnedMoney - tempMoneyVariaable)} left on your account.\nThank you for using the ATM app.");
            }
            else
            {
                Console.WriteLine("You do not have enough money on your account.");
            }
        }


        public void CashDeposition(double tempMoneyVariaable)
        {
               Console.WriteLine($"You deposited {string.Format("{0:C}", tempMoneyVariaable)}." +
                   $"You have {string.Format("{0:C}", OwnedMoney + tempMoneyVariaable)} left on your account.\nThank you for using the ATM app.  ");
        }

    }
}
