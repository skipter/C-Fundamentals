using System;
using System.Collections.Generic;
using System.Text;

namespace _03.OldestFamilyMember
{
    public class Person
    {
        private string name;
        private int age;

        //Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        //Constructors
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age)
            : this()            // :this() -> chaining constructors
        {
            this.Age = age;
        }

        public Person(string name, int age)
            : this(age)
        {
            this.Name = name;
        }
    }
}
