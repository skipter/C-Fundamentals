using System;

namespace BankAccount
{
    class StartUp
    {
        static void Main()
        {
            BankAccount acc = new BankAccount();
            //var account = new BankAccount();
            acc.Id = 1;
            acc.Balance = 15;

            Console.WriteLine($"Account {acc.Id}, balance {acc.Balance}");
        }
    }
}
