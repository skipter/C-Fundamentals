namespace _01.Logger.Appenders
{
    using Appenders.Contracts;
    using Layouts.Contracts;
    using Loggers.Enums;
    using System;

    public abstract class Appender : IAppender
    {
        private readonly ILayouts layout;

        protected Appender(ILayouts layout)
        {
            this.layout = layout;
        }

        protected ILayouts Layout => this.layout;

        public ReportLevel ReportLevel { get; set; }

        public int MessagesCount { get; protected set; }

        public abstract void Append(string dayTime, ReportLevel reportLevel, string message);


    }
}
