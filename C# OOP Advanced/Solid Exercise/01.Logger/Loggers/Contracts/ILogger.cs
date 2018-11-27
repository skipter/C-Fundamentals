namespace _01.Logger.Loggers.Contracts
{
    public interface ILogger
    {
        void Error(string dayTime, string errorMessage);

        void Info(string dayTime, string infoMessage);
    }
}
