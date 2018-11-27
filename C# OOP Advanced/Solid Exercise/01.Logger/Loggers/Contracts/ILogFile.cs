namespace _01.Logger.Loggers
{
    public interface ILogFile
    {
        void Write(string message);

        int Size { get; }
    }
}
