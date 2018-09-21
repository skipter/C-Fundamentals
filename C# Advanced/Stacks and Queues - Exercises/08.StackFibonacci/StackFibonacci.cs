using System;
using System.Collections.Generic;

namespace _08.StackFibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<long> fibonacci = new Stack<long>();

            fibonacci.Push(0);
            fibonacci.Push(1);

            for (int i = 0; i < num - 1; i++)
            {
                long firstNum = fibonacci.Pop();
                long secondNum = fibonacci.Peek();

                fibonacci.Push(firstNum);
                fibonacci.Push(firstNum + secondNum);
            }
            Console.WriteLine(fibonacci.Peek());
        }
    }
}
