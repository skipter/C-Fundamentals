namespace _03.Stack
{
    using System;
    using System.Linq;

    public class Engine
    {
        private bool isRun;

        public Engine()
        {
            this.isRun = true;
        }

        public void Run()
        {

            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions
                    .RemoveEmptyEntries)
                        .Skip(1)
                            .ToArray();

            var stack = new SpecialStack<string>(input);
            try
            {
                while (isRun)
                {
                    string[] inputArgs = Console.ReadLine().Split();
                    string command = inputArgs[0];

                    switch (command)
                    {
                        case "Pop":
                            stack.Pop();
                            break;
                        case "Push":
                            stack.Push(inputArgs[1]);
                            break;
                        case "END":
                            this.isRun = false;
                            for (int i = 0; i < 2; i++)
                            {
                                foreach (var item in stack)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


