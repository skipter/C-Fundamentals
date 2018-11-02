using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Mankind
{
    public class Worker : Human
    {
        private decimal salary;
        private decimal hours;

        public Worker(string firstName, string lastName, decimal salary, decimal hours) : base (firstName, lastName)
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
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.salary = value;
            }
        }
        public decimal Hours
        {
            get
            {
                return this.hours;
            }

            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.hours = value;
            }
        }

        private decimal SalaryPerHour()
        {
            return (this.Salary / 5) / this.Hours;
        }

        public override string ToString()
        {
            return $@"First Name: {this.FirstName}
Last Name: {this.LastName}
Week Salary: {this.Salary:f2}
Hours per day: {this.Hours:f2}
Salary per hour: {(SalaryPerHour()):f2}";

        }
    }
}
