using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Core
{
    public class Engine
    {
        private DungeonMaster dungeonMaster;

        public Engine()
        {
            this.dungeonMaster = new DungeonMaster();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];
                string[] args = inputArgs.Skip(1).ToArray();

                string result = String.Empty;

                switch (command)
                {
                    case "JoinParty":
                        result = dungeonMaster.JoinParty(args);
                        break;
                }

                Console.WriteLine(result);
            }
        }
    }
}
