using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    class ParkingLot
    {
        static void Main(string[] args)
        {
            HashSet<string> carPlates = new HashSet<string>();

            var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0] != "END")
            {
                string direction = input[0];
                string plate = input[1];

                if (input[0] == "IN")
                {
                    carPlates.Add(plate);
                }
                else if (input[0] == "OUT")
                {
                    carPlates.Remove(plate);
                }

                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            if (carPlates.Count > 0)
            {
                foreach (var plate in carPlates)
                {
                    Console.WriteLine(plate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
