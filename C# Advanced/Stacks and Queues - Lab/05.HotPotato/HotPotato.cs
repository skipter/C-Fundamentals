using System;
using System.Collections.Generic;

namespace _05.HotPotato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            //Input gamers names in collection.
            var gamersNames = Console.ReadLine().Split(" ");
            int number = int.Parse(Console.ReadLine());

            // Copies elements from the specified collection and keeps their order.
            Queue<string> queue = new Queue<string>(gamersNames); 

            while (queue.Count != 1) //Must left one children.
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue()); //First we remove the item, then we push(enqueue) it back in.
                }
                //Print the removed one.
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            //Print the last one standing.
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
