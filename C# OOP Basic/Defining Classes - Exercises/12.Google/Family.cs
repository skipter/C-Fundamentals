namespace _12.Google
{
    public class Family
    {
        private string name;
        private string date;
        

        public Family()
        {
            this.Name = "";
            this.Date = "";
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
    }
}
