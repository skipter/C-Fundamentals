namespace _01.Logger.Layouts.Factory.Contracts
{
    using _01.Logger.Layouts.Contracts;

    public interface ILayoutFactory
    {
        ILayouts CreateLayout(string type);
    }
}
