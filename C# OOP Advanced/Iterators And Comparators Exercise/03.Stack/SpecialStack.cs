using System;
using System.Collections;
namespace _03.Stack
{
    using System.Collections.Generic;
    using System.Linq;

    public class SpecialStack<T> : IEnumerable<T>
    {
        private readonly List<T> collection;

        public SpecialStack(params T[] collection)
        {
            this.collection = new List<T>(collection);
        }

        public int Count => this.collection.Count;

        public void Push(T element)
        {
            this.collection.Add(element);
        }

        public void Pop()
        {
            if(!this.collection.Any())
            {
                throw new InvalidOperationException("No elements");
            }

            this.collection.RemoveAt(this.collection.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.collection.Count - 1; i >= 0; i--)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
