﻿using Banking2C1.Models.Domain;
using System;

namespace Banking2C1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBA = new BankAccount("123-123123123-23")
            {
                Balance = 50
            };




            BankAccount anotherBA = new BankAccount("456-45645646-99", 1000);

            Console.WriteLine($"The withdrawcost is {BankAccount.WithdrawCost} Euro");
            Console.WriteLine($"Balance for anotherBA is {anotherBA.Balance} Euro");

            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            myBA.Deposit(100);
            myBA.Deposit(500);
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            myBA.Withdraw(50);
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            myBA.Withdraw(20);
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            Console.ReadKey();
        }
    }
}
