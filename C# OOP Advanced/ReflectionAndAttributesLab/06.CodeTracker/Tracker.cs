using System.Linq;
using System.Reflection;

public class Tracker
{
    public void PrintMethodsByAuthor()
    {
        var type = typeof(StartUp);

        var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

        foreach (var methodInfo in methods)
        {
            var customAttribute = methodInfo.GetCustomAttribute<SoftUniAttribute>();
            if (customAttribute != null)
            {
                System.Console.WriteLine($"{methodInfo.Name} is written by {customAttribute.Name}");
            }
        }
    }
}

