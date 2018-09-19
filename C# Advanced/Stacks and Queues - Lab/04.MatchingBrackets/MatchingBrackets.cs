using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            string expressionInput = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < expressionInput.Length; i++)
            {
                if (expressionInput[i] == '(')
                {
                    stack.Push(i);
                }

                if (expressionInput[i] == ')')
                {
                    int start = stack.Pop();
                    Console.WriteLine(expressionInput.Substring(start, i - start + 1));
                } 

            }
        }
    }
}
