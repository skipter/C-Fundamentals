using System;
using System.Collections.Generic;

namespace _02.SImpleCalculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var tokens = input.Split(" ");
            var stack = new Stack<string>();

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                stack.Push(tokens[i]);
            }

            while (stack.Count > 1)
            {
                var leftOperand = int.Parse(stack.Pop());
                var operand = stack.Pop();
                var rightOperator = int.Parse(stack.Pop());

                switch(operand)
                {
                    case "+":
                        stack.Push((leftOperand + rightOperator).ToString());
                        break;
                    case "-":
                        stack.Push((leftOperand - rightOperator).ToString());
                        break;
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
