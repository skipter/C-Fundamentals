using System;
using System.Collections.Generic;

namespace _03.DecimalToBinaryConverter
{
    class DecimalToBinaryConverter
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber == 0)
            {
                Console.WriteLine("0");
            } else
            {
                var stack = new Stack<int>();

                while (inputNumber > 0)
                {
                    int currentNumber = inputNumber % 2;
                    stack.Push(currentNumber);
                    inputNumber = inputNumber / 2;
                }

                foreach (var item in stack)
                {
                    Console.Write(item);
                }
                Console.WriteLine();

            }

        }
    }
}
