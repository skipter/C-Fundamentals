using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Mankind
{
    class Student : Human
    {
        private string facNumber;

        public Student(string firstName, string lastName, string facNumber) : base (firstName, lastName)
        {
            this.FacNumber = facNumber;
        }

        public string FacNumber
        {
            get
            {
                return this.facNumber;
            }

            set
            {
                if (value.Length < 5 && value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facNumber = value;
            }
        }
    }
}
