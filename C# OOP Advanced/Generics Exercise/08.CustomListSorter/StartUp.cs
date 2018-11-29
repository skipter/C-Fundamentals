using System;

namespace _07.CustomList
{
    public class StartUp
    {
        public static void Main()
        {
            ICustomList<string> customList = new CustomList<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];
                string element = String.Empty;
                switch (command)
                {
                    case "Add":
                        element = inputArgs[1];
                        customList.Add(element);
                        break;
                    case "Remove":
                        int index = int.Parse(inputArgs[1]);
                        customList.Remove(index);
                        break;
                    case "Contains":
                        element = inputArgs[1];
                        Console.WriteLine(customList.Contains(element));
                        break;
                    case "Swap":
                        int index1 = int.Parse(inputArgs[1]);
                        int index2 = int.Parse(inputArgs[2]);
                        customList.Swap(index1, index2);
                        break;
                    case "Greater":
                        element = inputArgs[1];
                        Console.WriteLine(customList.CountGreaterThan(element));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Print":
                        Console.WriteLine(customList);
                        break;
                    case "Sort":
                        customList.Sort();
                        break;
                    default:
                        break;
                }




                input = Console.ReadLine();
            }
        }
    }
}
