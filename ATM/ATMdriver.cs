using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class ATMdriver
    {
        public static void Main()
        {
            Console.WriteLine("Would you like to: (D)eposit, (W)ithdraw, (C)heck Balance, (T)ransfer, (Q)uit?");

            CheckingAccount checkingCurrency = new CheckingAccount();
            SavingsAccount savingsCurrency = new SavingsAccount();
            int transactionCounter = 0;
            
            do
            {
                if (Console.ReadKey().Equals('D')||Console.ReadKey().Equals('d'))
                {
                    Console.WriteLine("how many credits do you want to deposit?");
                    checkingCurrency.deposit(Convert.ToDecimal(Console.ReadLine()));
                    transactionCounter++;
                }


                if (transactionCounter == 5)
                {
                    savingsCurrency.applyInterestRate();
                    transactionCounter = 0;
                }


            } while (!Console.ReadKey().Equals('Q')|| !Console.ReadKey().Equals('q'));
            
            //read out after quitting
            Console.WriteLine($"Your final checking account balance is {checkingCurrency.getBalance()}");
            Console.WriteLine($"Your final savings account balance is {savingsCurrency.getBalance()}");
            Console.WriteLine("Thank you for your business, goodbye!");
        }
    }
}
