using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.KeyRevolver
{
    class KeyRevolver
    {
        static void Main()
        {

            int priceForBullet = int.Parse(Console.ReadLine());
            int gunSizeBarrel = int.Parse(Console.ReadLine());
            int[] bulletsIncome = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locksIncome = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int value = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsIncome);
            Queue<int> locks = new Queue<int>(locksIncome);

            int counter = 0;
            int bulletsShoots = 0;
            while (true)
            {

                if (bullets.Pop() <= locks.Peek())
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                counter++;
                if (counter == gunSizeBarrel && bullets.Count != 0)
                {
                    counter = 0;
                    Console.WriteLine("Reloading!");
                }
                bulletsShoots++;
                if (bullets.Count == 0 && locks.Count != 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    break;
                }
                else if (locks.Count == 0)
                {
                    int money = bulletsShoots * priceForBullet;
                    int bulletsLeft = bullets.Count + gunSizeBarrel;
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${value - money}");
                    break;
                }
            }
        }
    }
}
