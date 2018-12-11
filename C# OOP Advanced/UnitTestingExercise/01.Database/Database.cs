﻿using System;
using System.Linq;

namespace _01.Database
{
    public class Database
    {
        private Person[] database;
        private const int Capacity = 16;
        private int index;

        public Database(params Person[] data)
        {
            if (data.Length > 16)
            {
                throw new InvalidOperationException();
            }

            this.database = new Person[16];
            this.index = 0;

            foreach (var person in data)
            {
                this.Add(person);
            }
        }

        public void Add(Person item)
        {
            if (index == 16)
            {
                throw new InvalidOperationException();
            }

            if (this.database.Any(p => p != null && p.Id == item.Id))
            {
                throw new InvalidOperationException();
            }

            if (this.database.Any(p => p != null && p.Name == item.Name))
            {
                throw new InvalidOperationException();
            }

            this.database[index++] = item;
        }

        public Person Remove()
        {
            if (index == 0)
            {
                throw new InvalidOperationException();
            }

            return this.database[--index];
        }

        public Person[] Fetch()
        {
            return this.database.Take(index).ToArray();
        }

        public Person FindByUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException();
            }

            if (!this.database.Any(p => p != null && p.Name == username))
            {
                throw new InvalidOperationException();
            }

            return this.database.Single(p => p != null && p.Name == username);
        }

        public Person FindById(long id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (!this.database.Any(p => p != null && p.Id == id))
            {
                throw new InvalidOperationException();
            }

            return this.database.Single(p => p != null && p.Id == id);
        }
    }
}
