using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ATM
{
    class ATMdriver
    {
        static void Main(string[] args)
        {
            // initialise account
            CheckingAccount checkingCurrency = new CheckingAccount();
            SavingsAccount savingsCurrency = new SavingsAccount();
            
            // decalring objects and variables
            int transactionCounter = 0;
            ConsoleKeyInfo choice = new ConsoleKeyInfo();

            Console.WriteLine("Greetings and how may I serve you?");

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Would you like to: (D)eposit, (W)ithdraw, (C)heck Balance, (T)ransfer, (Q)uit?");
                choice = Console.ReadKey();

                switch (choice.KeyChar)
                {
                    case 'D':
                    case 'd':
                        Console.WriteLine("");
                        Console.WriteLine("how many credits do you want to deposit?");
                        checkingCurrency.deposit(Convert.ToDecimal(Console.ReadLine()));
                        transactionCounter++;
                        break;
                    case 'W':
                    case 'w':
                        Console.WriteLine("");
                        Console.WriteLine("how many credits do you want to withdraw?");
                        checkingCurrency.withdraw(Convert.ToDecimal(Console.ReadLine()));
                        transactionCounter++;
                        break;
                    case 'C':
                    case 'c':
                        Console.WriteLine("");
                        Console.WriteLine($"Your checking account has {checkingCurrency.getBalance()} credits");
                        Console.WriteLine($"Your savings account has {savingsCurrency.getBalance()} credits");
                        transactionCounter++;
                        break;
                    case 'T':
                    case 't':
                        decimal creditsToMove;
                        Console.WriteLine("");
                        Console.WriteLine("Transfer from (1)Checking to Savings or (2)Savings to Checking?");
                        choice = Console.ReadKey();
                        switch (choice.KeyChar)
                        {
                            case '1':
                                Console.WriteLine("");
                                Console.WriteLine("How many credits do you want to transfer to Savings account?");
                                creditsToMove = (Convert.ToDecimal(Console.ReadLine()));
                                checkingCurrency.withdraw(creditsToMove);
                                savingsCurrency.deposit(creditsToMove);
                                transactionCounter++;
                                break;
                            case '2':
                                Console.WriteLine("");
                                Console.WriteLine("How many credits do you want to transfer to checking account?");
                                creditsToMove = (Convert.ToDecimal(Console.ReadLine()));
                                savingsCurrency.withdraw(creditsToMove);
                                checkingCurrency.deposit(creditsToMove);
                                transactionCounter++;
                                break;
                        }
                        break;
                }

                if (transactionCounter == 5) // applies interest rates after 5 transactions
                {
                    Console.WriteLine("");
                    Console.WriteLine("Interest calculated!");
                    Console.WriteLine($"Your current checking account balance is {checkingCurrency.getBalance()} credits");
                    Console.WriteLine($"Your current savings account balance is {savingsCurrency.getBalance()} credits");
                    savingsCurrency.applyInterestRate();
                    transactionCounter = 0;
                }
            } while (choice.KeyChar != 'q');

            //read out after quitting
            Console.WriteLine("");
            Console.WriteLine($"Your final checking account balance is {checkingCurrency.getBalance()} credits");
            Console.WriteLine($"Your final savings account balance is {savingsCurrency.getBalance()} credits");
            Console.WriteLine("Thank you for your business, goodbye!");
            Console.ReadKey();
        }
    }
}
