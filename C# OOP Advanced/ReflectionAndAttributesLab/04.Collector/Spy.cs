﻿using System;
using System.Linq;
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

    public string AnalyzeAcessModifiers(string className)
    {
        StringBuilder sb = new StringBuilder();

        Type type = Type.GetType(className);

        FieldInfo[] publicFieldsNames = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

        MethodInfo[] privateMethodNames = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        MethodInfo[] publicMethodNames = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);

        foreach (var fieldName in publicFieldsNames)
        {
            sb.AppendLine($"{fieldName.Name} must be private!");
        }

        foreach (var methodName in privateMethodNames.Where(x => x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{methodName.Name} have to be public!");
        }

        foreach (var methodName in publicMethodNames.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{methodName.Name} have to be private!");
        }

        return sb.ToString()
            .TrimEnd();
    }

    public string RevealPrivateMethods(string className)
    {
        StringBuilder sb = new StringBuilder();

        Type type = Type.GetType(className);

        MethodInfo[] methodsInfo = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {type.BaseType.Name}");

        foreach (var method in methodsInfo)
        {
            sb.AppendLine($"{method.Name}");
        }

        return sb.ToString().TrimEnd();
    }

    public string CollectGettersAndSetters(string className)
    {
        Type classType = Type.GetType(className);

        MethodInfo[] methodsInfo = classType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        StringBuilder sb = new StringBuilder();

        foreach (MethodInfo method in methodsInfo.Where(x => x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} will return {method.ReturnType}");
        }

        foreach (MethodInfo method in methodsInfo.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return sb.ToString().TrimEnd();
    }
}

