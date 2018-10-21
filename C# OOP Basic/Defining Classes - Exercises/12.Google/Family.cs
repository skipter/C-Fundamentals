namespace _12.Google
{
    public class Family
    {
        private string name;
        private string date;
        

        public Family(string name, string date)
        {
            this.Name = name;
            this.Date = date;
        }

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

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Date}";
        }
    }
}
