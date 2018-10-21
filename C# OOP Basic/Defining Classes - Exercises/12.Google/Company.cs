namespace _12.Google
{
    public class Company
    {
        private string companyName;
        private string department;
        private decimal salary;

        public Company()
        {
            this.CompanyName = "";
            this.Department = "";
            this.Salary = 0M;
        }

        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                this.companyName = value;
            }
        }

        public string Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }
    }
}
