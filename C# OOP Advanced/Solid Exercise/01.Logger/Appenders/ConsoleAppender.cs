﻿namespace _01.Logger.Appenders
{
    using System;

    using Layouts.Contracts;
    using Loggers.Enums;

    public class ConsoleAppender : Appender
    {
       
        public ConsoleAppender(ILayouts layout)
            : base(layout)
        {
        }

        public override void Append(string dayTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                this.MessagesCount++;
                Console.WriteLine(string.Format(this.Layout.Format, dayTime, reportLevel, message));
            }
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, " +
                $"Report level: {this.ReportLevel.ToString().ToUpper()}, Messages appended: {this.MessagesCount}";
        }
    }
}
