namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Type type = typeof(HarvestingFields);

            FieldInfo[] fields = type.GetFields(BindingFlags.Public |
                BindingFlags.NonPublic | BindingFlags.Instance);

            while (input != "HARVEST")
            {
                // switch (input)
                // {
                //     case "private":
                //         break;
                //     case "public":
                //         break;
                //     case "protected":
                //         break;
                //
                //     default:
                //         break;
                // }

                

                if (input != "all")
                {
                    //This reflection replaces the swithc case method
                    FieldInfo[] fieldToPrint = fields
                    .Where(t => t.Attributes
                    .ToString()
                    .ToLower()
                    .Replace("family", "protected") == input)
                    .ToArray();

                    foreach (var field in fieldToPrint)
                    {
                        Console.WriteLine($"{field.Attributes.ToString().ToLower().Replace("family", "protected")} " +
                            $"{field.FieldType.Name} {field.Name}");
                    }
                }
                else
                {
                    foreach (var field in fields)
                    {
                        Console.WriteLine($"{field.Attributes.ToString().ToLower().Replace("family", "protected")} " +
                            $"{field.FieldType.Name} {field.Name}");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
