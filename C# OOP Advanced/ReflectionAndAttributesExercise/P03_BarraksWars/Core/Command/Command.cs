using _03BarracksFactory.Contracts;


namespace P03_BarraksWars.Core.Command
{
    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            Data = data;
            Repository = repository;
            UnitFactory = unitFactory;
        }

        public string[] Data
        {
            get { return this.data; }

            private set { this.data = value; }
        }

        public IRepository Repository
        {
            get { return this.repository; }

            private set { this.repository = value; }
        }

        public IUnitFactory UnitFactory
        {
            get { return this.unitFactory; }

            private set { this.unitFactory = value; }
        }

        public abstract string Execute();
    }
}
