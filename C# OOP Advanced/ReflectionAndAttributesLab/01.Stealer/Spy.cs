using System;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string className, params string[] fieldsToInvestigate)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Class under investigation: {className}");

        //Look in that class "Hacker"
        Type type = Type.GetType(className);

        //Object or var
        Object hackerInstance = Activator.CreateInstance(type);

        for (int i = 0; i < fieldsToInvestigate.Length; i++)
        {
            //Get all fields 
            var field = type.GetField(fieldsToInvestigate[i], BindingFlags.Public |
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);

            var value = field.GetValue(hackerInstance);
            //currentField .Name - optional
            sb.AppendLine($"{field.Name} = {value}");

        }

        return sb.ToString()
            .TrimEnd();
    }
}

