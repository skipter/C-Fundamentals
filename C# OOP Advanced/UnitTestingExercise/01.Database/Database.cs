using System;
using System.Linq;

namespace _01.Database
{
    public class Database
    {
        private const int Capacity = 16;
        private int[] data;
        private int index;

        public Database()
        {
            this.data = new int[Capacity];
            //TODO Test index
            this.index = -1;
        }

        public Database(int[] values)
            :this()
        {
            if (values.Length > 16)
            {
                throw new InvalidOperationException("Parameter is too long!");
            }

            for (int i = 0; i < values.Length; i++)
            {
                this.data[i] = values[i];
            }

            this.index = values.Length - 1;
        }

        public void Add(int value)
        {
            //TODO test if index value is 15
            if(this.index < Capacity - 1)
            {
                this.data[++this.index] = value;
                return;
            }

            throw new InvalidOperationException("Database is full!");
        }

        public void Remove()
        {
            //Check this case
            if (this.index == -1)
            {
                throw new InvalidOperationException("Database is empty!");
            }

            this.data[this.index] = 0;
            this.index--;
        }

        public int[] Fetch()
        {
            return this.data.Take(this.index + 1).ToArray();
        }
    }
}
