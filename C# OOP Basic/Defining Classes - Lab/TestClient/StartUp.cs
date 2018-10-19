using System;
using System.Collections.Generic;

namespace TestClient
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> data = new Dictionary<int, BankAccount>();

            string input = Console.ReadLine();

            while (input != "End")
            {

                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];

                switch (command)
                {
                    case "Create":
                        Create(cmdArgs, data);
                        break;

                    case "Deposit":
                        Deposit(cmdArgs, data);
                        break;

                    case "Withdraw":
                        Withdraw(cmdArgs, data);
                        break;

                    case "Print":
                        Print(cmdArgs, data);
                        break;
                }

                input = Console.ReadLine();
            }
        }

        private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> data)
        {
            
        }

        private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> data)
        {
            
        }

        private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> data)
        {
           
        }

        private static void Create (string[] cmdArgs, Dictionary<int, BankAccount> account)
        {
            var id = int.Parse(cmdArgs[1]);
       
            if (account.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.Id = id;
                account.Add(id, acc);
            }
        }
    }
}
