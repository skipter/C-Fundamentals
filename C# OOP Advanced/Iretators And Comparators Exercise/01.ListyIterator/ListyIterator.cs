namespace _01.ListyIterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;

        public ListyIterator(params T[] collection)
        {
            this.Index = 0;
            this.collection = new List<T>(collection);
        }

        public int Index { get; private set; }

        public bool Move()
        {
            if (!HasNext())
            {
                return false;
            }
            this.Index++;
            return true;
        }

        public bool HasNext()
        {
            bool hasNextElement = Index < this.collection.Count - 1;
            return hasNextElement;
        }

        public void Print()
        {
            if (!this.collection.Any())
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(this.collection[Index]);
        }

        public void PrintAll()
        {
            if (!this.collection.Any())
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(string.Join(" ", this.collection).TrimEnd());
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection[i];
            }
        }
       
        //Awlays -> return GetEnumerator() - its a bad legacy
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
