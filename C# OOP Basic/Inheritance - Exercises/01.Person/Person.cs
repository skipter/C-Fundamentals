using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Person
{
    public class Person
    {

        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
                name = value;
            }
        }
        public virtual int Age
        {
            get
            {
                return this.age;
            }
            set
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                else if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
                age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(String.Format($"Name: {this.Name}, Age: {this.Age}"));
            return sb.ToString();
        }
    }
}
