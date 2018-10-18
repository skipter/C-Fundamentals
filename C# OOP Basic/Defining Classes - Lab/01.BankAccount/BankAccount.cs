using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        //Fields
        private int id;

        private decimal balance;

        //public decimal Balance { get; set; }
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
        
        
    }
}
