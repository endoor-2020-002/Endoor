using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class SavingsAccount
    {
        // fields
        decimal _balance { get; set; }
        decimal _interestRate { get; set; }

        // constructor
        public SavingsAccount(decimal balance, decimal interestRate)
        {
            _balance = balance;
            _interestRate = interestRate;
        }

        public SavingsAccount(decimal balance) : this(balance, 0.01m)
        {
        }

        public SavingsAccount() : this(10m)
        {
        }



        // methods
        public void withdraw(decimal money)
        {
            _balance = _balance - money;
        }

        public decimal getBalance()
        {
            return _balance;
        }

        public void deposit(decimal money)
        {
            _balance = _balance + money;
        }

        // extra methods
        public void setInterestRate(decimal InterestRate)
        {
            _interestRate = InterestRate;
        }

        public decimal getInterestRate()
        {
            return _interestRate;
        }

        public void applyInterestRate()
        {
            _balance += _balance * _interestRate;
        }


    }
}
