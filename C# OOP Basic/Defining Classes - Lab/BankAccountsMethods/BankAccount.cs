using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{   //public, if it isnt, by default it is private
    public class BankAccount
    {
        private int id;

        private decimal balance;

        public decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        //Must be void
        //Add money
        public void Deposit (decimal amount)
        {
            this.Balance += amount;
        }
        //Withdraw money
        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {this.Id}, balance {this.Balance}";
        }
    }
}
