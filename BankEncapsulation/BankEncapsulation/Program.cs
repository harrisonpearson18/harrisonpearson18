﻿using System;
using System.Net.Http.Headers;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine("How much money would you like to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);

            double userBalance = ba.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance, 0:c}");

            Console.WriteLine("How much money would you like to deposit?");
            double amountToDeposit2 = double.Parse(Console.ReadLine());
            ba.Deposit(amountToDeposit2);
            double userBalance2 = ba.GetBalance();
            Console.WriteLine($"Your current balance is: {userBalance2,0:c}");

        }
    }
}
