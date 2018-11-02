using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Mankind
{
    class Worker : Human
    {
        private decimal salary;
        private int hours;

        public Worker(string firstName, string lastName, decimal salary, int hours) : base (firstName, lastName)
        {
            this.Salary = salary;
            this.Hours = hours;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.salary = value;
            }
        }
        public int Hours
        {
            get
            {
                return this.hours;
            }

            set
            {
                if (value < 1 && value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.hours = value;
            }
        }
    }
}
