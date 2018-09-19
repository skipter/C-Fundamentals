using System;
using System.Collections.Generic;

namespace _07.BalancedParenthesis
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().ToCharArray();

            Stack<char> stack = new Stack<char>();
            var symbolsPairs = new Dictionary<char, char>();
            symbolsPairs['{'] = '}';
            symbolsPairs['['] = ']';
            symbolsPairs['('] = ')';

            if (input.Length % 2 != 0 || input.Length == 0)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (var character in input)
            {
                if (symbolsPairs.ContainsKey(character))
                {
                    stack.Push(character);
                }
                else
                {
                    var remove = stack.Pop();
                    if (symbolsPairs[remove] != character)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
