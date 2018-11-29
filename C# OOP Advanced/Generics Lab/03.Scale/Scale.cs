namespace GenericScale
{
    using System;

    public class Scale<T>
        where T : IComparable<T>
    {
        private T left;
        private T right;

        public Scale(T left, T right) //to set value must be set in the constructor
        {
            this.Left = left;
            this.Right = right;
        }

        public T Left { get; }
        public T Right { get; }

        public T GetHeavier()
        {
            if (this.Left.CompareTo(this.Right) < 0)
            {
                return this.Right;
            }
            if (this.Left.CompareTo(this.Right) > 0)
            {
                return this.Left;
            }

            return default(T);
        }
    }
}
