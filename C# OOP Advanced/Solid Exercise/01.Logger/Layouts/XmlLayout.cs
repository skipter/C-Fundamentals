
namespace _01.Logger.Layouts
{
    using _01.Logger.Layouts.Contracts;

    public class XmlLayout : ILayouts
    {
        public string Format => "<log>\n" +
                                "   <date>{0}</date>\n" +
                                "   <level>{1}</level>\n" +
                                "   <message>{2}</message>\n" +
                                "</log>";
    }
}
