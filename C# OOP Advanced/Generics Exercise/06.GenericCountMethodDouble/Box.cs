using System;
using System.Collections.Generic;
using System.Text;

namespace _06.GenericCountMethodDouble
{
    public class Box<T>
         where T : IComparable<T>
    {
        public Box(List<T> items)
        {
            this.Items = items;
        }

        public List<T> Items { get; set; }

        public int GetComparable(T currentItem)
        {
            int counter = 0;

            foreach (var item in this.Items)
            {
                if (item.CompareTo(currentItem) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
