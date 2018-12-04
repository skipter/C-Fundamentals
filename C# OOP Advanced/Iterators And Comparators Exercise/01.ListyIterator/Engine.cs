using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ListyIterator
{
    public class Engine
    {
        private bool isRun;
        private ListyIterator<string> listyIterator;

        public Engine()
        {
            this.isRun = true;
        }

        public void Run()
        {
            while (isRun)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string command = inputArgs[0];

                try
                {
                    ExecuteFunction(inputArgs, command);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void ExecuteFunction(string[] inputArgs, string command)
        {
            switch (command)
            {
                case "Create":
                    this.listyIterator = new ListyIterator<string>(inputArgs.Skip(1).ToArray());
                    break;
                case "Move":
                    Console.WriteLine(this.listyIterator.Move());
                    break;
                case "Print":
                    this.listyIterator.Print();
                    break;
                case "HasNext":
                    Console.WriteLine(this.listyIterator.HasNext());
                    break;
                case "PrintAll":
                    this.listyIterator.PrintAll();
                    break;
                case "END":
                    isRun = false;
                    break;
            }
        }
    }
}
