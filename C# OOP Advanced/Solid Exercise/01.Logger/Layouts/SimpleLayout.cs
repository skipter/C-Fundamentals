namespace _01.Logger.Layouts
{

    using Contracts;

    public class SimpleLayout : ILayouts
    {
        public string Format => "{0} - {1} - {2}";
    }
}
