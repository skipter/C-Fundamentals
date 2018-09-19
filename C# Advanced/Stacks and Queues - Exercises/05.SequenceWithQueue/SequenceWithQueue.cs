using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05.SequenceWithQueue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            List<long> resultNumber = new List<long>();
            Queue<long> queue = new Queue<long>();

            queue.Enqueue(number);
            resultNumber.Add(number);

            for (int i = 0; i < 17; i++)
            {
                long currentNumber = queue.Dequeue();

                long a = currentNumber + 1;
                long b = currentNumber * 2 + 1;
                long c = currentNumber + 2;

                queue.Enqueue(a);
                queue.Enqueue(b);
                queue.Enqueue(c);

                resultNumber.Add(a);
                resultNumber.Add(b);
                resultNumber.Add(c);
            }
            Console.WriteLine(String.Join(" ", resultNumber.Take(50)));
        }
    }
}
