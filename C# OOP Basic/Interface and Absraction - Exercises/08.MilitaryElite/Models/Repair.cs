using _08.MilitaryElite.Contracts;

namespace _08.MilitaryElite.Models
{
    public class Repair : IRepair
    {
        private string partName;
        private int hoursWork;

        public Repair(string partName, int hoursWork)
        {
            this.PartName = partName;
            this.HoursWork = hoursWork;
        }

        public string PartName
        {
            get => partName;
            private set => partName = value;
        }
        public int HoursWork
        {
            get => hoursWork;
            private set => hoursWork = value;
        }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWork}";
        }
    }
}
