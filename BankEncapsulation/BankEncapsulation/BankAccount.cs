using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public BankAccount()
        {

        }

        public void Deposit(double amount)
        {
            Console.WriteLine($"Simulating a deposit of {amount, 0:c} to you account");
            balance += amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
