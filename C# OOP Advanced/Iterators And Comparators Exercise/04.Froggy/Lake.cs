namespace _04.Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake : IEnumerable<int>
    {
        private readonly List<int> collection;

        public Lake(params int[] collection)
        {
            this.collection = new List<int>(collection);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i+=2)
            {
                yield return this.collection[i];
            }

            for (int j = this.collection.Count - 1; j >= 0; j-=2)
            {
                if (this.collection.Count % 2 == 1 && j == collection.Count - 1)
                {
                    j++;
                    continue;
                }
                yield return this.collection[j];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
