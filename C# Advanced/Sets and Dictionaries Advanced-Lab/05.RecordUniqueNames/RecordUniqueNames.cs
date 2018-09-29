﻿using System;
using System.Collections.Generic;

namespace _05.RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            int nameCount = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < nameCount; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
