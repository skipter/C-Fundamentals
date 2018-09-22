using System;
using System.Collections.Generic;
namespace _09.SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string text = String.Empty;
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < num; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                int operation = int.Parse(tokens[0]);

                
                switch (operation)
                {
                    case 1:
                        //Append
                        string currentText = tokens[1];
                        stack.Push(text);
                        text += currentText;
                        break;

                    case 2:
                        //Erase
                        int count = int.Parse(tokens[1]);
                        stack.Push(text);
                        text = text.Substring(0, text.Length - count);
                        break;

                    case 3:
                        //Return element at position
                        int index = int.Parse(tokens[1]);
                        Console.WriteLine(text[index - 1]);
                        break;

                    case 4:
                        //Undoes
                        text = stack.Pop();
                        break;
                }

            }
        }
    }
}
