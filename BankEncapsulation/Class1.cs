using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    class BankAccount
    {
        private double _balance;

        public BankAccount(double balance)
        {
            _balance = balance;
        }

        public void Deposit(double amount)
        {
            Console.WriteLine($"Simulating a deposit of {amount, 0:c} to you account");
            balance = amount;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
