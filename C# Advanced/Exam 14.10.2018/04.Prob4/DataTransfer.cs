using System;
using System.Collections.Generic;

namespace _04.Prob4
{
    class prob4
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();
            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine();

                if (input.Contains("s:") && input.Contains(";r:") && input.Contains(";m--"))
                {
                    var tokens = input.Split(new string[] { "s:", ";r:", ";m--" }, StringSplitOptions.RemoveEmptyEntries);
                    string sender = tokens[0];
                    string receiver = tokens[1];
                    string message = tokens[2];

                    if (!data.ContainsKey(sender))
                    {
                        data.Add(sender, new Dictionary<string, string>());
                        data[sender].Add(receiver, message);
                    }

                }
            }
            int totalData = 0;
            //Take names
            foreach (var sender in data)
            {
                string name = String.Empty;
                foreach (var character in sender.Key)
                {
                    if (Char.IsLetter(character))
                    {
                        name += character;
                        totalData += character;
                    }
                }
                result.Add(name, new Dictionary<string, string>());

                string receiverName = String.Empty;
                foreach (var character in sender.Key)
                {
                    if (Char.IsLetter(character))
                    {
                        receiverName += character;
                        totalData += character;
                    }
                }

                string message = String.Empty;
                foreach (var currentMessage in sender.Value)
                {

                }

                result[name].Add(receiverName, message);
            }


            //Print
            foreach (var name in result)
            {
                Console.Write($"{name.Key} says ");

                foreach (var user in name.Value)
                {
                    //Console.Write($"{}");
                }
            }

            Console.WriteLine($"Total data transferred: {totalData}MB");
        }

    }
}
