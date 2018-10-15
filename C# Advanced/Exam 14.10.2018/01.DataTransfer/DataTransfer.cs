using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.DataTransfer
{
    class DataTransfer
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            string pattern = "^s:(.*?);r:(.*?);m--\"([a-zA-Z ]*)\"";   //^s:(group1);r:(Group2);m--"(Group3)"
            int mb = 0;
            List<string> messages = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                Match validate = Regex.Match(input, pattern);   //Check input with regex

                if (validate.Success)
                {
                    mb += validate.Value.ToString()     //Take the string and check every char is it digit
                        .Where(x => Char.IsDigit(x))    // and take its sum to mb.
                        .Select(x => x - '0')
                        .Sum();

                    string sender = Name(validate.Groups[1].ToString()); //Take sender from Group1
                    string receiver = Name(validate.Groups[2].ToString());//Take receiver from Group2
                    string message = Name(validate.Groups[3].ToString());//Take message from Group3

                    messages.Add(sender + " says \"" + message + "\" to " + receiver);
                }
            }
            foreach (var str in messages)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine($"Total data transferred: {mb}MB");
        }
        //Method to extract only letters from groups. CHeck every symbol in group is it char or whitespace and string.join it in array.
        private static string Name(string str) => string.Join("", str.Where(c => char.IsLetter(c) || c == ' ').ToArray());
    }
}
