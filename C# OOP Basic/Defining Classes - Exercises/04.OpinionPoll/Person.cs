using System;
using System.Collections.Generic;
using System.Text;

namespace _04.OpinionPoll
{
    public class Person
    {
        private string name;
        private int age;
        private List<Person> members;
       

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age > 30)
                {
                    throw new Exception();
                }

                age = value;
            }
        }

        public List<Person> Members
        {
            get => members;
            set => members = value;
        }

        public Person (string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public void AddMember (Person member)
        {
            if (member == null )
            {
                throw new Exception();
                
            }
        }
    }
}
