namespace _12.Google
{
    public 
        class Pokemon
    {
        private string name;
        private string type;

        public Pokemon()
        {
            this.Name = "";
            this.Type = "";
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

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
    }
}
