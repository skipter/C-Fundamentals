namespace _01.Logger
{
    using System;

    using Appenders;
    using Appenders.Contracts;
    using Layouts;
    using Layouts.Contracts;
    using Loggers.Contracts;
    using Loggers;
    using Loggers.Enums;
    using _01.Logger.Core.Contracts;
    using _01.Logger.Core;

    public class StartUp
    {
        static void Main(string[] args)
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            IEngine engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
