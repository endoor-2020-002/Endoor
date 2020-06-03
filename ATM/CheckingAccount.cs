using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class CheckingAccount
    {
        // should keep track of the balance

        //fields
        decimal _balance { get; set; }


        //constructor
        public CheckingAccount(decimal balance)
        {
            _balance = balance;
        }

        public CheckingAccount() : this(10m)
        {
        }

        //methods

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


    }
}
