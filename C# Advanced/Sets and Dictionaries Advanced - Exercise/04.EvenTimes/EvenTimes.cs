using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class EvenTimes
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<int, int> nums = new Dictionary<int, int>();

            int counter = 1;

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (!nums.ContainsKey(currentNum))
                {
                    nums.Add(currentNum, counter);
                }
                else
                {
                    nums[currentNum] += 1;
                }
            }
            
            foreach (var number in nums)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
