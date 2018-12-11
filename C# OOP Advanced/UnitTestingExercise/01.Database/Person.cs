namespace _01.Database
{
    public class Person
    {
        private long id;
        private string name;

        public Person(long id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public long Id { get; private set; }
        public string Name { get; private set; }
    }
}
