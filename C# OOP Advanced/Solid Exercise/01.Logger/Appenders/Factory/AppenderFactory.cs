namespace _01.Logger.Appenders.Factory
{
    using _01.Logger.Appenders.Contracts;
    using _01.Logger.Appenders.Factory.Contracts;
    using _01.Logger.Layouts.Contracts;
    using _01.Logger.Loggers;
    using System;

    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayouts layout)
        {
            string typeAsLowerCase = type.ToLower();

            switch (typeAsLowerCase)
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile());
                default:
                    throw new ArgumentException("Invalid appender type!");
            }
        }
    }
}
