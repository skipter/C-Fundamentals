namespace _01.Logger.Appenders.Factory.Contracts
{
    using _01.Logger.Appenders.Contracts;
    using _01.Logger.Layouts.Contracts;

    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayouts layout);
    }
}
